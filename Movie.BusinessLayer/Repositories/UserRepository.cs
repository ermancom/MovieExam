using Movie.Database;
using Movie.Entities;
using System.Linq;

namespace Movie.BusinessLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MovieDbContext dbContext;

        public UserRepository(MovieDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User GetUser(string username, string password)
        {
           return dbContext.Users.SingleOrDefault(user => user.Username == username && user.Password == password);    
        }


    }
}
