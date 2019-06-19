using Requisições_Internas.Domain.Features.Requests;
using Requisições_Internas.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Features.Requests
{
    public class RequestRepository : IRequestRepository
    {
        ContextInternalRequisitions _contextInternalRequisitions;
        public RequestRepository(ContextInternalRequisitions contextInternalRequisitions)
        {
            _contextInternalRequisitions = contextInternalRequisitions;
        }
        public long Add(Request entity)
        {
            _contextInternalRequisitions.Requests.Add(entity);

            _contextInternalRequisitions.SaveChanges();

            return entity.Id;
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Request> GetAll()
        {
            return _contextInternalRequisitions.Requests
                .Include(r => r.User)
                .Include(r => r.ProductsRequest);
        }

        public Request GetById(long id)
        {
            return _contextInternalRequisitions.Requests
                .Where(r => r.Id == id)
                .Include(r => r.User)
                .Include(r => r.ProductsRequest)
                .FirstOrDefault();
        }

        public bool Update(Request entity)
        {
            return _contextInternalRequisitions.SaveChanges() != 0;
        }
    }
}
