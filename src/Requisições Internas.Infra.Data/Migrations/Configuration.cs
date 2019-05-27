namespace Requisições_Internas.Infra.Data.Migrations
{
    using Requisições_Internas.Domain.Features.Units;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DropCreateDatabaseIfModelChanges<Context.ContextInternalRequisitions>
    {
        protected override void Seed(Context.ContextInternalRequisitions context)
        {

            List<Unit> units = new List<Unit>();
            units.Add(new Unit() { Name = "Caixa" });
            units.Add(new Unit() { Name = "Unidade" });
            units.Add(new Unit() { Name = "Litro" });

            context.Units.AddRange(units);

            base.Seed(context);
        }
    }
}
