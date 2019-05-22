using Requisições_Internas.Domain.Features.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Features.Products
{
    public class ProductRepository : IProductRepository
    {
        public long Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public long Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(long id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
