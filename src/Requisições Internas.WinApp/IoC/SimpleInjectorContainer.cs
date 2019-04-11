using Requisições_Internas.Application.Features.Providers;
using Requisições_Internas.Domain.Features.Providers;
using Requisições_Internas.Infra.Data.Context;
using Requisições_Internas.Infra.Data.Features.Providers;
using Requisições_Internas.WinApp.Features.Products;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.WinApp.IoC
{
    public class SimpleInjectorContainer
    {
        public static Container Container { get; set; }
        public static void RegisterInstances()
        {
            Container = new Container();

            Container.Register<ProductControl>(Lifestyle.Singleton);
            Container.Register<IProviderRepository, ProviderRepository>(Lifestyle.Singleton);
            Container.Register<IProviderService, ProviderService>(Lifestyle.Singleton);
            Container.Register(() => new ContextInternalRequisitions(), Lifestyle.Singleton);

            Container.Verify();
        }
    }
}
