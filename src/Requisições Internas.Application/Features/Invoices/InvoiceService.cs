using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Requisições_Internas.Domain.Features.Invoices;

namespace Requisições_Internas.Application.Features.Invoices
{
    public class InvoiceService : IInvoiceService
    {
        IInvoiceRepository _invoiceRepository;
        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        public long Add(Invoice entity)
        {
            return _invoiceRepository.Add(entity);
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _invoiceRepository.GetAll();
        }

        public Invoice GetById(long id)
        {
            return _invoiceRepository.GetById(id);
        }

        public bool Update(Invoice entity)
        {
            throw new NotImplementedException();
        }
    }
}
