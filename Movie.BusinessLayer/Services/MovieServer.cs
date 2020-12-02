using Movie.BusinessLayer.Repositories;
using Movie.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.BusinessLayer.Services
{
    public class MovieServer : IMovieService 
    {
        private readonly IMovieRepository movieRepository;

        public MovieServer(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public List<MovieModel> GetMovies(string title, string genres, int? yearOfRelease)
        {
            return movieRepository.GetMovies(title, genres, yearOfRelease);
        }

        public List<MovieModel> GetTopFiveMoviesForAllUser()
        {
            return movieRepository.GetTopFiveMoviesForAllUser();
        }

        public List<MovieRateModel> GetTopFiveMoviesHighestRatesFromUser(int userId)
        {
            return movieRepository.GetTopFiveMoviesHighestRatesFromUser(userId);
        }

        public int GetMovieIDByTitle(string title)
        {
            return movieRepository.GetMovieIDByTitle(title);
        }

        public void MovieRateUpdateOrInsert(int movieId, int userId, int rate)
        {
            movieRepository.MovieRateUpdateOrInsert(movieId, userId, rate);
        }
    }
}
