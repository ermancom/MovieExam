using MediatR;
using Movie.Api.Queries;
using Movie.BusinessLayer;
using Movie.Entities.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Movie.Api.Handlers
{
    public class GetTopFiveMoviesForAllUserHandler: IRequestHandler<GetTopFiveMoviesForAllUserQuery, List<MovieModel>>
    {
        private IBusinessService businessService;

        public GetTopFiveMoviesForAllUserHandler(IBusinessService businessService)
        {
            this.businessService = businessService;
        }

        public Task<List<MovieModel>> Handle(GetTopFiveMoviesForAllUserQuery request, CancellationToken cancellationToken)
        {
            var movieModels = businessService.Movies.GetTopFiveMoviesForAllUser();
            return Task.FromResult(movieModels);
        }
    }
}
