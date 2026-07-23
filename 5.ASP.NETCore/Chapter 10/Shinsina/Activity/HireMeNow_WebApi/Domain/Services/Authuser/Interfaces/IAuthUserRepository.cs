using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Authuser.Interfaces
{
    public interface IAuthUserRepository
    {   
        string? CreateToken(AuthUser user);
    }
}
