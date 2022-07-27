using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryContracts
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmail(string email);
        Task<User> AddUser(User user);
    }
}
