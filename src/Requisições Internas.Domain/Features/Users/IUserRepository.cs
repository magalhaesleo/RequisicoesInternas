﻿using Requisições_Internas.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Domain.Features.Users
{
    public interface IUserRepository : IRepository<User>
    {
        User Authenticate(string user, string password);
    }
}
