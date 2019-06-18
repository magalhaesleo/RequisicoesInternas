namespace Requisições_Internas.Infra.Data.Migrations
{
    using Requisições_Internas.Domain.Features.Units;
    using Requisições_Internas.Domain.Features.Users;
    using Requisições_Internas.Domain.Object_Values;
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

            List<User> users = new List<User>();

            users.Add(new User() { Name = "Leonardo", Password = "teste", Group = UserGroup.Normal, Birth = new DateTime(1996, 4, 10) });
            users.Add(new User() { Name = "admin", Password = "admin",  Group = UserGroup.Admin, Birth = new DateTime(1996, 4, 10) });

            context.Users.AddRange(users);

            base.Seed(context);
        }
    }
}
