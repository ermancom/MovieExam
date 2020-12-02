using Movie.Database;
using Movie.Entities;
using Movie.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Movie.BusinessLayer.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext dbContext;

        public MovieRepository(MovieDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<MovieModel> GetMovies(string title, string genres, int? yearOfRelease)
        {
            var query = from movie in dbContext.Movies
                        where
                             (!string.IsNullOrWhiteSpace(title) ? (title == movie.Title) : true)
                          && (!string.IsNullOrWhiteSpace(genres) ? (genres == movie.Genres) : true)
                          && (yearOfRelease != null ? (yearOfRelease == movie.YearOfRelease) : true)
                        select
                             new MovieModel()
                             {
                                 ID = movie.ID,
                                 Title = movie.Title,
                                 YearOfRelease = movie.YearOfRelease,
                                 Genres = movie.Genres,
                                 RunningTime = movie.RunningTime,
                                 AverageRating = Math.Round(dbContext.MovieRates.Where(mr => mr.MovieID == movie.ID).Average(mr => mr.UserRate),1, MidpointRounding.AwayFromZero)                                                      
                             };

           return query.ToList();
        }

        public List<MovieModel> GetTopFiveMoviesForAllUser()
        {
            var query = (from movie in dbContext.Movies
                         select
                            new MovieModel()
                            {
                                ID = movie.ID,
                                Title = movie.Title,
                                YearOfRelease = movie.YearOfRelease,
                                Genres = movie.Genres,
                                RunningTime = movie.RunningTime,
                                AverageRating = dbContext.MovieRates.Where(mr => mr.MovieID == movie.ID).Average(mr => mr.UserRate)
                            }
                          ).OrderByDescending(key => key.AverageRating).OrderBy(key => key.Title)
                           .Select(mv => new MovieModel()
                           {
                               ID = mv.ID,
                               Title = mv.Title,
                               YearOfRelease = mv.YearOfRelease,
                               Genres = mv.Genres,
                               RunningTime = mv.RunningTime,
                               AverageRating = Math.Round(mv.AverageRating,1, MidpointRounding.AwayFromZero)
                           })
                           .Take(5);

            return query.ToList();
        }

        public List<MovieRateModel> GetTopFiveMoviesHighestRatesFromUser(int userId)
        {
            var query = (from movieRate in dbContext.MovieRates
                         join movie in dbContext.Movies on movieRate.MovieID equals movie.ID
                         join user in dbContext.Users on movieRate.UserID equals user.ID
                         where
                              movieRate.UserID == userId
                         orderby movieRate.UserRate descending, movie.Title
                         select
                               new MovieRateModel()
                               {
                                   ID = movie.ID,
                                   Title = movie.Title,
                                   Genres = movie.Genres,
                                   RunningTime = movie.RunningTime,
                                   YearOfRelease = movie.YearOfRelease,
                                   UserRate = movieRate.UserRate,
                                   Username = user.Username
                               }
                        ).Take(5);
            
            return query.ToList();
        }


        public int GetMovieIDByTitle(string title)
        {
           return dbContext.Movies.Where(m => m.Title == title).Select(m => m.ID).SingleOrDefault();
        }

        public void MovieRateUpdateOrInsert(int movieId, int userId, int rate)
        {
            var movieRate = dbContext.MovieRates.Where(mr => mr.MovieID == movieId && mr.UserID == userId).SingleOrDefault();
            if (movieRate == null)
            {
                dbContext.MovieRates.Add(new MovieRate() { MovieID = movieId, UserID = userId, UserRate = rate });
            }
            else {
                    movieRate.UserRate = rate;
                    dbContext.MovieRates.Update(movieRate);
                 }
            dbContext.SaveChanges();
        }


    }
}
