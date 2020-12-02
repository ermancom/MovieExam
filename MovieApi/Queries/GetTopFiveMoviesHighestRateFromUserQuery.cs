using MediatR;
using Movie.Entities.Models;
using System.Collections.Generic;

namespace Movie.Api.Queries
{
    public class GetTopFiveMoviesHighestRateFromUserQuery : IRequest<List<MovieRateModel>>
    {
    }
}
