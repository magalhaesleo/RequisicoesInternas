using Requisições_Internas.Domain.Features.Invoices;
using Requisições_Internas.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Features.Invoices
{
    public class InvoiceRepository : IInvoiceRepository
    {
        ContextInternalRequisitions _contextInternalRequisitions;
        public InvoiceRepository(ContextInternalRequisitions contextInternalRequisitions)
        {
            _contextInternalRequisitions = contextInternalRequisitions;
        }
        public long Add(Invoice entity)
        {
            _contextInternalRequisitions.Invoices.Add(entity);

            _contextInternalRequisitions.SaveChanges();

            return entity.Id;
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _contextInternalRequisitions.Invoices.Include(i => i.Products);
        }

        public Invoice GetById(long id)
        {
            return _contextInternalRequisitions.Invoices.Where(i => i.Id == id)
                .Include(i => i.Products).FirstOrDefault();
        }

        public bool Update(Invoice entity)
        {
            throw new NotImplementedException();
        }
    }
}
