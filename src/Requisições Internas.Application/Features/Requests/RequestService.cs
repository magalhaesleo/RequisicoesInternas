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
        readonly IRequestRepository _requestRepository;
        readonly PDFExport _pdfExport;
        public RequestService(IRequestRepository requestRepository, PDFExport pdfExport)
        {
            _requestRepository = requestRepository;
            _pdfExport = pdfExport;
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
            return _pdfExport.GenerateRequestReport(_requestRepository, filePath);
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
