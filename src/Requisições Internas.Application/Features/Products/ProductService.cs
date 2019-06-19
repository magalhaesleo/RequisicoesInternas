using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Requisições_Internas.Domain.Base;
using Requisições_Internas.Domain.Features.Products;
using Requisições_Internas.Infra.Exports;

namespace Requisições_Internas.Application.Features.Products
{
    public class ProductService : IProductService
    {
        readonly IProductRepository _productRepository;
        readonly PDFExport _pdfExport;
        public ProductService(IProductRepository productRepository, PDFExport pdfExport)
        {
            _productRepository = productRepository;
            _pdfExport = pdfExport;
        }
        public long Add(Product entity)
        {
            return _productRepository.Add(entity);
        }

        public bool Delete(long id)
        {
            return _productRepository.Delete(id);
        }

        public bool GeneratePDFReport(string filePath)
        {
            return _pdfExport.GenerateProductsReport(_productRepository, filePath);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(long id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<Product> GetByName(string word)
        {
            return _productRepository.GetName(word);
        }

        public bool Update(Product entity)
        {
            return _productRepository.Update(entity);
        }
    }
}
