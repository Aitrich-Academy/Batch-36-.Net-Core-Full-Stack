using JobPortalApplication.Interfaces;
using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>()
        {
            new User{Id=1, Name="job provider", Email="jobprovider@gmail.com", Password="123", Role=Enums.Role.Provider}
        };

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetUsers()
        {
            return users;
        }

        public User GetUser(string email, string password)
        {
            return users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
