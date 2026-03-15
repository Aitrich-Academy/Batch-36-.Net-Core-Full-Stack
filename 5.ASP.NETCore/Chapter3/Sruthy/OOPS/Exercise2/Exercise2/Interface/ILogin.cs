using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Exercise2.Model;

namespace Exercise2.Interface
{
    internal interface ILogin
    {
        public bool Login(string username, string password);
        public void Register(User user);


    }
}
