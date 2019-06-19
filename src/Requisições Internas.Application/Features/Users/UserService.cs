using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Requisições_Internas.Domain.Base;
using Requisições_Internas.Domain.Features.Users;
using Requisições_Internas.Infra.Exports;

namespace Requisições_Internas.Application.Features.Users
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepository;
        readonly PDFExport _pdfExport;
        public UserService(IUserRepository userRepository, PDFExport pdfExport)
        {
            _userRepository = userRepository;
            _pdfExport = pdfExport;
        }

        public long Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Authenticate(string user, string password)
        {
            return _userRepository.Authenticate(user, password);
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public bool GeneratePDFReport(string filePath)
        {
            return _pdfExport.GenerateUsersReport(_userRepository, filePath);
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
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
