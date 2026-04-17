using Exercise3.Interface;
using Exercise3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Repository
{
    public class UserRepository : IUserRepository
    {
        private static List<User> users = new List<User>();
        private int count = 1;

        public void Register(User user)
        {
            // check duplicate email
            if (users.Any(u => u.Email == user.Email))
            {
                throw new Exception("Email already exists");
            }

            user.Id = count++;
            users.Add(user);
        }

        public User Login(string email, string password)
        {
            return users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public List<User> GetAllUsers()
        {
            return users;
        }
    }
}
