using Requisições_Internas.Domain.Features.Invoices;
using Requisições_Internas.Domain.Features.Products;
using Requisições_Internas.Domain.Features.Providers;
using Requisições_Internas.Domain.Features.Requests;
using Requisições_Internas.Domain.Features.Users;
using Requisições_Internas.Infra.Data.Features.Invoices;
using Requisições_Internas.Infra.Data.Features.Products;
using Requisições_Internas.Infra.Data.Features.Providers;
using Requisições_Internas.Infra.Data.Features.Requests;
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
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ContextInternalRequisitions, Migrations.Configuration>());
            //Database.SetInitializer<ContextInternalRequisitions>(new DropCreateDatabaseIfModelChanges<ContextInternalRequisitions>());
        }
        public ContextInternalRequisitions() : this("InternalRequisitionsDB")
        {
        }

        public DbSet<Provider> Providers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProviderConfiguration());
            modelBuilder.Configurations.Add(new InvoiceConfiguration());
            modelBuilder.Configurations.Add(new RequestConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
