
using Movie.Entities;

namespace Movie.BusinessLayer.Services
{
    public interface IAuthenticationService
    {
        User GetUser(string userName, string password);
    }
}
