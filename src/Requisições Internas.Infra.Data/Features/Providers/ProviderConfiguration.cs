using Requisições_Internas.Domain.Features.Providers;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Features.Providers
{
    public class ProviderConfiguration : EntityTypeConfiguration<Provider>
    {
        public ProviderConfiguration()
        {
            ToTable("TbProvider");
            HasKey(provider => provider.Id);
            Property(provider => provider.Name).HasColumnName("Name").IsRequired();
            Property(provider => provider.CNPJ).HasColumnName("CNPJ").IsRequired();
            Property(provider => provider.Enabled).HasColumnName("Enabled");
            Property(provider => provider.Telephone).HasColumnName("Telephone").IsRequired();
        }
    }
}
