using MediatR;
using Movie.Api.Commands;
using Movie.BusinessLayer;
using Movie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Movie.Api.Handlers
{
    public class GiveRateToMoveCommandHandler : IRequestHandler<GiveRateToMoveCommand, bool>
    {
        private IBusinessService businessService;
        private IPipelineContext pipelineContext;

        public GiveRateToMoveCommandHandler(IBusinessService businessService, IPipelineContext pipelineContext)
        {
            this.businessService = businessService;
            this.pipelineContext = pipelineContext;
        }

        public Task<bool> Handle(GiveRateToMoveCommand request, CancellationToken cancellationToken)
        {
            int movieID = businessService.Movies.GetMovieIDByTitle(request.Title);
            if (movieID == 0)
                return Task.FromResult(false);

            businessService.Movies.MovieRateUpdateOrInsert(movieID, pipelineContext.UserId, request.Rate);

            return Task.FromResult(true);
        }
    }
}
