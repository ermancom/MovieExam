using Movie.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.BusinessLayer.Repositories
{
    public interface IUserRepository
    {
        User GetUser(string username, string password);
    }
}
