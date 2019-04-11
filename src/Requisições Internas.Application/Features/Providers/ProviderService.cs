using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Requisições_Internas.Domain.Features.Providers;

namespace Requisições_Internas.Application.Features.Providers
{
    public class ProviderService : IProviderService
    {
        private IProviderRepository _providerRepository;
        public ProviderService(IProviderRepository providerRepository)
        {
            _providerRepository = providerRepository;
        }
        public long Add(Provider provider)
        {
            return _providerRepository.Add(provider);
        }

        public long Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Provider> GetAll()
        {
            return _providerRepository.GetAll();
        }

        public Provider GetById(long id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Provider entity)
        {
            throw new NotImplementedException();
        }
    }
}
