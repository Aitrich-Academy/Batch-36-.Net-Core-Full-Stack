using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Services.Authuser;
using Domain.Services.Authuser.Interfaces;
using Domain.Services.Login.DTOs;
using Domain.Services.Login.Interfaces;


namespace Domain.Services.Login
{
    public class LoginRequestService : ILoginRequestService
    {
        ILoginRequestRepository   loginRepository;
        IAuthUserRepository authUserRepository;
        IMapper mapper;
        public LoginRequestService(ILoginRequestRepository _jobSeekerRepository, IMapper _mapper, IAuthUserRepository _authUserRepository)
        {
            loginRepository = _jobSeekerRepository;
            mapper = _mapper;
            
            authUserRepository = _authUserRepository;
        }

     

        public AdminLoginDTO Adminlogin(string email, string password)
        {
            var user = loginRepository.GetUserByEmail(email);
            if (user == null)
            {
                return null;
            }
            else
            {
                if ((password == user.Password))
                {
                    var userReturn = mapper.Map<AdminLoginDTO>(user);
                    userReturn.Token = authUserRepository.CreateToken(user);
                    return userReturn;
                }
                return null;
            }

        }
    }
       
    }

