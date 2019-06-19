using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Requisições_Internas.Domain.Base;
using Requisições_Internas.Domain.Features.Providers;
using Requisições_Internas.Infra.Exports;

namespace Requisições_Internas.Application.Features.Providers
{
    public class ProviderService : IProviderService
    {
        private readonly IProviderRepository _providerRepository;
        readonly PDFExport _pdfExport;
        public ProviderService(IProviderRepository providerRepository, PDFExport pdfExport)
        {
            _providerRepository = providerRepository;
            _pdfExport = pdfExport;
        }
        public long Add(Provider provider)
        {
            return _providerRepository.Add(provider);
        }

        public bool Delete(long id)
        {
            return _providerRepository.Delete(id);
        }

        public bool GeneratePDFReport(string filePath)
        {
            return _pdfExport.GenerateProvidersReport(_providerRepository, filePath);
        }

        public IEnumerable<Provider> GetAll()
        {
            return _providerRepository.GetAll();
        }

        public Provider GetById(long id)
        {
            return _providerRepository.GetById(id);
        }

        public bool Update(Provider entity)
        {
            return _providerRepository.Update(entity);
        }
    }
}
