using Requisições_Internas.Application.Base;
using Requisições_Internas.Domain.Features.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Application.Features.Products
{
    public interface IProductService : IService<Product>
    {
        IEnumerable<Product> GetByName(string word);
    }
}
