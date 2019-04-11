using Requisições_Internas.Domain.Features.Providers;
using Requisições_Internas.Infra.Data.Features.Providers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Context
{
    public class ContextInternalRequisitions : DbContext
    {
        public ContextInternalRequisitions(string dataBaseName) : base(dataBaseName)
        {
            Configuration.ProxyCreationEnabled = false;
        }
        public ContextInternalRequisitions() : this("InternalRequisitionsDB")
        {

        }

        public DbSet<Provider> Providers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProviderConfiguration());
        }
    }
}
