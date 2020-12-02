using MediatR;
using Movie.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Api.Queries
{
    public class GetTopFiveMoviesForAllUserQuery : IRequest<List<MovieModel>>
    {
    }
}
