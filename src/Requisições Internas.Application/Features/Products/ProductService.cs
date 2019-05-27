using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Requisições_Internas.Domain.Features.Products;

namespace Requisições_Internas.Application.Features.Products
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public long Add(Product entity)
        {
            return _productRepository.Add(entity);
        }

        public bool Delete(long id)
        {
            return _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(long id)
        {
            return _productRepository.GetById(id);
        }

        public bool Update(Product entity)
        {
            return _productRepository.Update(entity);
        }
    }
}
