using Movie.Entities.Models;
using System.Collections.Generic;

namespace Movie.BusinessLayer.Services
{
    public interface IMovieService
    {
        List<MovieModel> GetMovies(string title, string genres, int? yearOfRelease);
        List<MovieModel> GetTopFiveMoviesForAllUser();
        List<MovieRateModel> GetTopFiveMoviesHighestRatesFromUser(int userId);
        int GetMovieIDByTitle(string title);
        void MovieRateUpdateOrInsert(int movieId, int userId, int rate);
    }
}
