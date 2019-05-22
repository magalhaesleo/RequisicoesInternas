using Requisições_Internas.Domain.Features.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Features.Products
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("TBProducts");
        }
    }
}
