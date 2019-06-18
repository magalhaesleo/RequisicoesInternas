using Requisições_Internas.Domain.Base;
using Requisições_Internas.Domain.Features.ProductRequests;
using Requisições_Internas.Domain.Features.Users;
using Requisições_Internas.Domain.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Domain.Features.Requests
{
    public class Request: Entity
    {
        public User User { get; set; }
        public IEnumerable<ProductRequest> ProductsRequest { get; set; }
        public DateTime DateRequest { get; set; }
        public Status Status { get; set; }
        public DateTime ? AcceptanceDate { get; set; }
        public DateTime ? DeliveryDate { get; set; }
    }
}
