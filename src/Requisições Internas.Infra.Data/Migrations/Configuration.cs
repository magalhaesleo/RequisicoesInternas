namespace Requisições_Internas.Infra.Data.Migrations
{
    using Requisições_Internas.Domain.Features.Units;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Requisições_Internas.Infra.Data.Context.ContextInternalRequisitions>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Requisições_Internas.Infra.Data.Context.ContextInternalRequisitions context)
        {

            List<Unit> units = new List<Unit>();
            units.Add(new Unit() { Name = "Caixa" });

            context.Units.AddRange(units);

            base.Seed(context);
        }
    }
}
