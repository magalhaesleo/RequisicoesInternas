using Requisições_Internas.Domain.Base;
using Requisições_Internas.Domain.Features.Products;
using Requisições_Internas.Domain.Features.Providers;
using Requisições_Internas.Domain.Features.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Domain.Features.Invoices
{
    public class Invoice : Entity
    {
        public string Number { get; set; }
        public string Sequence { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
        public Provider Provider { get; set; }
        public List<Product> Products { get; set; }
    }
}
