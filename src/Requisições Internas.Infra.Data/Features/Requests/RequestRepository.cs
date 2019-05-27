using Requisições_Internas.Domain.Features.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Features.Requests
{
    public class RequestRepository : IRequestRepository
    {
        public long Add(Request entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Request> GetAll()
        {
            throw new NotImplementedException();
        }

        public Request GetById(long id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Request entity)
        {
            throw new NotImplementedException();
        }
    }
}
