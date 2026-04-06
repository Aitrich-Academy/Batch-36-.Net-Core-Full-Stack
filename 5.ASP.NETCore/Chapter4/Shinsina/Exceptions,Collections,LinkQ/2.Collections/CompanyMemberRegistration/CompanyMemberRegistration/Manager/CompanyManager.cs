using CompanyMemberRegistration.Exceptions;
using CompanyMemberRegistration.Interfaces;
using CompanyMemberRegistration.Model;
using CompanyMemberRegistration.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace CompanyMemberRegistration.Manager
{
    internal class CompanyManager:IMenu
    {
        CompanyRepository CompanyRepository=new CompanyRepository();
        CompanyManager cmpmanager;
        Lists list = new Lists();
        IMenu menu;
        public void DisplayMenu() 
        {
            ShowCompanyMenu();
        }

        private void ShowCompanyMenu()
        {
            bool showMenu = false;

            while (!showMenu)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. List Companies");
                Console.WriteLine("3. JobProvider Menu");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                string choice1=Console.ReadLine();
                switch (choice1) 
                {
                    case "1":
                        Console.WriteLine("Register a Company");
                        RegisterCompany();
                        ShowCompanyMenu();
                        break;

                    case "2":
                        Console.WriteLine("\nList Of Companies");
                        List<Company> companies = CompanyRepository.ListCompanies();
                        //list.print(companies);
                        Console.WriteLine();
                        ShowCompanyMenu();
                        break;

                    case "3":
                        Console.WriteLine("\nJob Provider Menu");
                        ShowCompanyMenu();
                        break;

                    case "4":
                        break;

                    default:
                        
                            Console.WriteLine("Invalid Option");
                            ShowCompanyMenu();
                            break;
                }

                
            }

        }
        private void RegisterCompany()
        {
            try

            {
                Company company = new Company();
                Console.WriteLine("Enter your company name :");
                company.Name = Console.ReadLine();


                company.Email = GetEmail(); ;

                Console.WriteLine("Please enter your Company Website");
                company.Website = Console.ReadLine();


                company.Phone = GetPhoneNumber();

                Console.WriteLine("Enter about Company");
                company.About = Console.ReadLine();

                Console.WriteLine("Enter Company Vision");
                company.Vision = Console.ReadLine();

                Console.WriteLine("Enter Company Mission");
                company.Mission = Console.ReadLine();

                Console.WriteLine("Enter Company Location");
                company.Location = Console.ReadLine();

                Console.WriteLine("enter Company Address");
                company.Address = Console.ReadLine();

                bool result = CompanyRepository.register(company);
                if (result == true)
                {
                    Console.WriteLine("Registration Sucessfull");
                    Console.ReadLine();

                    ShowCompanyMenu();
                }



            }
            catch (UserAlreadyExistException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        private long GetPhoneNumber()
        {
            try
            {
                Console.WriteLine("Enter your phone number :");
                long phoneNumber = long.Parse(Console.ReadLine());
                return phoneNumber;
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter valid phone number");
                return GetPhoneNumber();
            }

        }

        private string GetEmail()
        {
            try
            {
                Console.WriteLine("Please enter your email address:");
                string email = Console.ReadLine();
                Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");

                if (!regex.IsMatch(email))
                    throw new InvalidFormatException("email was not in correct format :" + email);
                return email;
            }
            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("try again...");
                return GetEmail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                return GetEmail();
            }
        }
    }

  
}
