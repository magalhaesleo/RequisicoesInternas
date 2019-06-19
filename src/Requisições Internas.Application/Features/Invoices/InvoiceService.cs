using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Requisições_Internas.Domain.Base;
using Requisições_Internas.Domain.Features.Invoices;
using Requisições_Internas.Infra.Exports;

namespace Requisições_Internas.Application.Features.Invoices
{
    public class InvoiceService : IInvoiceService
    {
        readonly IInvoiceRepository _invoiceRepository;
        readonly PDFExport _pdfExport;
        public InvoiceService(IInvoiceRepository invoiceRepository, PDFExport pdfExport)
        {
            _invoiceRepository = invoiceRepository;
            _pdfExport = pdfExport;
        }
        public long Add(Invoice entity)
        {
            return _invoiceRepository.Add(entity);
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public bool GeneratePDFReport(string filePath)
        {
            return _pdfExport.GenerateInvoicesReport(_invoiceRepository, filePath);
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
