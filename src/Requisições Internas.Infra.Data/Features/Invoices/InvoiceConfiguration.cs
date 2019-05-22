using Requisições_Internas.Domain.Features.Invoices;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Features.Invoices
{
    public class InvoiceConfiguration : EntityTypeConfiguration<Invoice>
    {
        public InvoiceConfiguration()
        {
            ToTable("TBInvoices");
        }
    }
}
