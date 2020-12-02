using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Entities
{
    public class PipelineContext : IPipelineContext
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
