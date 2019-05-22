using Requisições_Internas.Domain.Base;
using Requisições_Internas.Domain.Features.Invoices;
using Requisições_Internas.Domain.Features.Requests;
using Requisições_Internas.Domain.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Domain.Features.Products
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public string Description { get; set; }
        public bool Enabled { get; set; }
        public List<Invoice> Invoices { get; set; }
        public List<Request> Requests { get; set; }
    }
}
