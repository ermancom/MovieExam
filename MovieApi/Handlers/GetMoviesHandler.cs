using MediatR;
using Microsoft.Extensions.Configuration;
using Movie.Api.Queries;
using Movie.BusinessLayer;
using Movie.Entities.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Movie.Api.Handlers
{
    public class GetMoviesHandler : IRequestHandler<GetMoviesRequestQuery, List<MovieModel>>
    {
        private IBusinessService businessService;

        public GetMoviesHandler(IBusinessService businessService)
        {
            this.businessService = businessService;
        }

        public Task<List<MovieModel>> Handle(GetMoviesRequestQuery request, CancellationToken cancellationToken)
        {
            var movieModels = businessService.Movies.GetMovies(request.Title, request.Genres, request.YearOfRelease);
            return Task.FromResult(movieModels);
        }
    }
}
