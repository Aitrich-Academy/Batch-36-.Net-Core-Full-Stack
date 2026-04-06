using JobPortalApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobPortalApplication.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        List<User> GetUsers();
        User GetUser(string email, string password);
       
    }
}
