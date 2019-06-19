using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Requisições_Internas.Domain.Base;
using Requisições_Internas.Domain.Features.Requests;
using Requisições_Internas.Infra.Exports;

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

        public bool GeneratePDFReport(string filePath)
        {
            PDFExport export = new PDFExport();
            return export.GenerateRequestReport(_requestRepository, filePath);
        }

        public IEnumerable<Request> GetAll()
        {
            return _requestRepository.GetAll();
        }

        public Request GetById(long id)
        {
            return _requestRepository.GetById(id);
        }

        public bool Update(Request entity)
        {
            return _requestRepository.Update(entity);
        }
    }
}
