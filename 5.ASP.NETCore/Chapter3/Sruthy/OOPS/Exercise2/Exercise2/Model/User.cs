using Exercise2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
    }
}
