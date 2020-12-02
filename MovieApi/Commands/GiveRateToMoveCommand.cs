using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Api.Commands
{
    public class GiveRateToMoveCommand : IRequest<bool>
    {
        public string Title {get;set;}
        public int Rate { get; set; }
    }
}
