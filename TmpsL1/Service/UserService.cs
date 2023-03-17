using System;
using TmpsL1.Interface;
using TmpsL1.Models;

namespace TmpsL1.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repository;

        public UserService(IRepository<User> repository)
        {
            this.repository = repository;
        }
        public void AddUser(User user)
        {
            repository.Add(user);
        }

        public User GetUserById(int id)
        {
            var result = repository.GetById(id);
            
            if (result == null)
            {
                return new User { Id = 555 };
            }

            return result;
        }

        public void SaveUsers()
        {
            repository.Save();
        }
    }
}
