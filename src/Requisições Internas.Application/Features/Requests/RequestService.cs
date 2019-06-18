using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Requisições_Internas.Domain.Features.Requests;

namespace Requisições_Internas.Application.Features.Requests
{
    public class RequestService : IRequestService
    {
        IRequestRepository _requestRepository;
        public RequestService(IRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }
        public long Add(Request entity)
        {
            return _requestRepository.Add(entity);
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Request> GetAll()
        {
            return _requestRepository.GetAll();
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
