using Requisições_Internas.Domain.Base;
using Requisições_Internas.Domain.Features.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Domain.Features.ProductRequests
{
    public class ProductRequest : Entity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
