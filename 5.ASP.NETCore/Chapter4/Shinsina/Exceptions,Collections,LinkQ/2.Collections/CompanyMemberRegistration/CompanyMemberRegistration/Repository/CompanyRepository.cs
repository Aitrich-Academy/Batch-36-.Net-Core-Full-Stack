using CompanyMemberRegistration.Exceptions;
using CompanyMemberRegistration.Interfaces;
using CompanyMemberRegistration.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace CompanyMemberRegistration.Repository
{
    public class CompanyRepository:ICompanyRepository
    {
        private int _id = 0;

        List<Company> companies = new List<Company>();
        public bool register(Company company)
        {
            company.Id=_id;
            _id++;
            if (companies.Find(e => e.Email == company.Email) == null)
            {
                companies.Add(company);
                return true;
            }
            throw new UserAlreadyExistException(company.Email);
        }
        public List<Company> ListCompanies()
        {
            return companies;
        }
    }
}
