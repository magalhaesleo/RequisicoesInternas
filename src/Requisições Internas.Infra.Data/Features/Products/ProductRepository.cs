using Requisições_Internas.Domain.Features.Products;
using Requisições_Internas.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Features.Products
{
    public class ProductRepository : IProductRepository
    {
        readonly ContextInternalRequisitions _contextInternalRequisitions;
        public ProductRepository(ContextInternalRequisitions contextInternalRequisitions)
        {
            _contextInternalRequisitions = contextInternalRequisitions;
        }
        public long Add(Product entity)
        {
            _contextInternalRequisitions.Products.Add(entity);
            _contextInternalRequisitions.SaveChanges();

            return entity.Id;
        }

        public bool Delete(long id)
        {
            _contextInternalRequisitions.Products.Remove(GetById(id));
            return _contextInternalRequisitions.SaveChanges() != 0;
        }

        public IEnumerable<Product> GetAll()
        {
            return _contextInternalRequisitions.Products;
        }

        public Product GetById(long id)
        {
            return _contextInternalRequisitions.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Update(Product entity)
        {
            return _contextInternalRequisitions.SaveChanges() != 0;
        }
    }
}
