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

            Container.Verify();
        }
    }
}
