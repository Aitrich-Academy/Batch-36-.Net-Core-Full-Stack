using Exercise3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Interface
{
    public interface IUserRepository
    {
        void Register(User user);
        User Login(string email, string password);
        List<User> GetAllUsers();
    }
}
