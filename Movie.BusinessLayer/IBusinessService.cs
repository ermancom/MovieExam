using Movie.BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.BusinessLayer
{
    public interface IBusinessService
    {
        IAuthenticationService Authentications { get; }
        IMovieService Movies { get; }
    }
}
