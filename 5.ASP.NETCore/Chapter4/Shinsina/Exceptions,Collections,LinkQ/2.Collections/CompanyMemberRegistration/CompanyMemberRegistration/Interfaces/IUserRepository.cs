using CompanyMemberRegistration.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyMemberRegistration.Interfaces
{
    internal interface IUserRepository
    {
        bool register(Company company);
    }
}
