using MediatR;
using Movie.Api.Queries;
using Movie.BusinessLayer;
using Movie.Entities;
using Movie.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Movie.Api.Handlers
{
    public class GetTopFiveMoviesHighestRateFromCurrentUserHandler : IRequestHandler<GetTopFiveMoviesHighestRateFromUserQuery, List<MovieRateModel>>
    {
        private IBusinessService businessService;
        private IPipelineContext pipelineContext;

        public GetTopFiveMoviesHighestRateFromCurrentUserHandler(IBusinessService businessService, IPipelineContext pipelineContext)
        {
            this.businessService = businessService;
            this.pipelineContext = pipelineContext;
        }

        public Task<List<MovieRateModel>> Handle(GetTopFiveMoviesHighestRateFromUserQuery request, CancellationToken cancellationToken)
        {
            var movieRateModels = businessService.Movies.GetTopFiveMoviesHighestRatesFromUser(this.pipelineContext.UserId);
            return Task.FromResult(movieRateModels);
        }
    }
}
