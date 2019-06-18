using Requisições_Internas.Application.Base;
using Requisições_Internas.Domain.Features.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Application.Features.Users
{
    public interface IUserService : IService<User>
    {
        User Authenticate(string user, string password);
    }
}
