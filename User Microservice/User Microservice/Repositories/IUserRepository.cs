using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Microservice.Models;

namespace User_Microservice.Repositories
{
    public interface IUserRepository
    {
        public void AddUser(User user);
        public void DeleteUser(int id);
        public User GetUserById(int id);
        public List<User> GetUsers();
        public void UpdateUser(User user);
    }
}
