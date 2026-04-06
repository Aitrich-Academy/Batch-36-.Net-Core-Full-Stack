using CompanyMemberRegistration.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyMemberRegistration.Interfaces
{
    public interface ICompanyRepository
    {
        bool register(Company company);
        List<Company> ListCompanies();
    }
}
