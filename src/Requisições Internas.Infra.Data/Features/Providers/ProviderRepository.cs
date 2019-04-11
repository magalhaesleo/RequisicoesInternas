using Requisições_Internas.Domain.Features.Providers;
using Requisições_Internas.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Features.Providers
{
    public class ProviderRepository : IProviderRepository
    {
        private ContextInternalRequisitions _contextInternalRequisitions;
        public ProviderRepository(ContextInternalRequisitions contextInternalRequisitions)
        {
            _contextInternalRequisitions = contextInternalRequisitions;
        }
        public long Add(Provider provider)
        {
            var providerAdded = _contextInternalRequisitions.Providers.Add(provider);

            _contextInternalRequisitions.SaveChanges();

            return providerAdded.Id;
        }

        public long Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Provider> GetAll()
        {
            return _contextInternalRequisitions.Providers;
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
