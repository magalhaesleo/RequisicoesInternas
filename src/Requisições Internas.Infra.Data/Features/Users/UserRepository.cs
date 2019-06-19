using Requisições_Internas.Domain.Features.Users;
using Requisições_Internas.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Features.Users
{
    public class UserRepository : IUserRepository
    {
        ContextInternalRequisitions _contextInternalRequisitions;
        public UserRepository(ContextInternalRequisitions contextInternalRequisitions)
        {
            _contextInternalRequisitions = contextInternalRequisitions;
        }
        public long Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Authenticate(string user, string password)
        {
            var userAuth = _contextInternalRequisitions.Users
                .Where(u => u.Name == user)
                .Where(u => u.Password == password)
                .FirstOrDefault();

            return userAuth;
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _contextInternalRequisitions.Users;
        }

        public User GetById(long id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
