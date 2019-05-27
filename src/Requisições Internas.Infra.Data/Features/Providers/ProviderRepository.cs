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

        public bool Delete(long id)
        {
             _contextInternalRequisitions.Providers.Remove(GetById(id));
            return _contextInternalRequisitions.SaveChanges() != 0;
        }

        public IEnumerable<Provider> GetAll()
        {
            return _contextInternalRequisitions.Providers;
        }

        public Provider GetById(long id)
        {
            return _contextInternalRequisitions.Providers.
                Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update(Provider entity)
        {
             return _contextInternalRequisitions.SaveChanges() != 0;
        }
    }
}
