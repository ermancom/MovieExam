using MediatR;
using Movie.Entities.Models;


namespace Movie.BusinessLayer.Queries
{
    public class LoginRequestQuery : IRequest<LoginModel>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
