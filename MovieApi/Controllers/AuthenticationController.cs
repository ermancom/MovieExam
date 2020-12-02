using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movie.BusinessLayer;
using Movie.BusinessLayer.Queries;
using Movie.Entities.Models;

namespace Movie.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthenticationController(IMediator mediator)
        {
            this.mediator = mediator;
        }

       [HttpPost]
       [Route("login")]
       public async Task<IActionResult> Login([FromBody] LoginRequestQuery loginRequestQuery)
        {
            var loginResponse = await mediator.Send<LoginModel>(loginRequestQuery);
           return Ok(loginResponse);
        }
    }
}
