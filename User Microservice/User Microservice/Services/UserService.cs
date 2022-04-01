using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Microservice.Models;
using User_Microservice.Repositories;

namespace User_Microservice.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;
        public UserService(IUserRepository userRepository)
        {
            repository = userRepository;
        }

        public void AddUser(User user)
        {
            repository.AddUser(user);
        }

        public void DeleteUser(int id)
        {
            repository.DeleteUser(id);
        }

        public User GetUserById(int id)
        {
            return repository.GetUserById(id);
        }

        public List<User> GetUsers()
        {
            return repository.GetUsers();
        }

        public void UpdateUser(User user)
        {
            repository.UpdateUser(user);
        }
    }
}
