using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;
using System.Linq;
using Movie.Entities;

namespace Movie.Api.Middlewares
{
    public class PipelineContextFilter : ActionFilterAttribute
    {
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var pipelineContext = context.HttpContext.RequestServices.GetRequiredService<IPipelineContext>();

            pipelineContext.UserId = Convert.ToInt32(context.HttpContext.User.Claims.ElementAt(0).Value);
            pipelineContext.UserName = context.HttpContext.User.Claims.ElementAt(1).Value;

            return base.OnActionExecutionAsync(context, next);
        }
    }
}
