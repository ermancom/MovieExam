using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Entities
{
    public interface IPipelineContext
    {
        int UserId { get; set; }
        string UserName { get; set; }
    }
}
