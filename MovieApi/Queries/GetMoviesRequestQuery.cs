using MediatR;
using Movie.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Api.Queries
{
    public class GetMoviesRequestQuery: IRequest<List<MovieModel>>
    {
        public string Title { get; set; }
        public string Genres { get; set; }
        public int? YearOfRelease { get; set; }
    }
}
