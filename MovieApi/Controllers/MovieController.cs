using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie.Api.Commands;
using Movie.Api.Middlewares;
using Movie.Api.Queries;
using Movie.Entities.Models;

namespace Movie.Api.Controllers
{
    [Authorize]
    [PipelineContextFilter]
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMediator mediator;

        public MovieController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Route("movies")]
        public async Task<IActionResult> GetMovies([FromQuery] string title, [FromQuery] int? yearOfRelease, [FromQuery] string genres)
        {
            if (string.IsNullOrWhiteSpace(title) && yearOfRelease is null && string.IsNullOrWhiteSpace(genres))
                return BadRequest();

            var movieList = await mediator.Send<List<MovieModel>>(new GetMoviesRequestQuery() { Title = title, Genres = genres, YearOfRelease = yearOfRelease });
            if (movieList.Count == 0)
                return NotFound();

            return Ok(movieList);
        }

        [HttpGet]
        [Route("getTopFiveMovies")]
        public async Task<IActionResult> GetTopFiveMoviesForAllUser()
        {
            var movieList = await mediator.Send<List<MovieModel>>(new GetTopFiveMoviesForAllUserQuery());
            if (movieList.Count == 0)
                return NotFound();

            return Ok(movieList);
        }

        [HttpGet]
        [Route("getTopFiveMoviesCurrentUser")]
        public async Task<IActionResult> GetTopFiveMoviesHighestRateFromUser()
        {
            var movieRateList = await mediator.Send<List<MovieRateModel>>(new GetTopFiveMoviesHighestRateFromUserQuery());
            if (movieRateList.Count == 0)
                return NotFound();

            return Ok(movieRateList);
        }

        [HttpPost]
        [Route("giveRateToMovie/title/{title}/rate/{rate:int:range(1,5)}")]
        public async Task<IActionResult> GiveRateToMovie([FromRoute] string title, [FromRoute] int rate)
        {
            if (string.IsNullOrWhiteSpace(title))
                return BadRequest();

            var ok = await mediator.Send<bool>(new GiveRateToMoveCommand() { Title = title, Rate = rate });
            if (!ok)
                return NotFound();

            return Ok();
        }
    }
}
