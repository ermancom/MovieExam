using Movie.BusinessLayer.Repositories;
using Movie.Entities;

namespace Movie.BusinessLayer.Services
{
    public class AuthenticationServer : IAuthenticationService
    {
        private readonly IUserRepository userRepository;

        public AuthenticationServer(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User GetUser(string userName, string password)
        {
            return this.userRepository.GetUser(userName, password);
        }
    }
}
