using Movie.BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.BusinessLayer
{
    public class BusinessServer : IBusinessService
    {
        private IAuthenticationService authenticationService;
        private IMovieService movieService;

        public BusinessServer(IAuthenticationService authenticationService,
                              IMovieService movieService)
        {
            this.authenticationService = authenticationService;
            this.movieService = movieService;
        }

        public IAuthenticationService Authentications
        {
            get { return this.authenticationService; }     
        }

        public IMovieService Movies
        {
            get { return this.movieService; }
        }

    }
}
