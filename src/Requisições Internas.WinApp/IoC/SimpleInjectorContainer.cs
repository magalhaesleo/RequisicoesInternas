﻿using Requisições_Internas.Application.Features.Invoices;
using Requisições_Internas.Application.Features.Products;
using Requisições_Internas.Application.Features.Providers;
using Requisições_Internas.Application.Features.Requests;
using Requisições_Internas.Application.Features.Units;
using Requisições_Internas.Application.Features.Users;
using Requisições_Internas.Domain.Features.Invoices;
using Requisições_Internas.Domain.Features.Products;
using Requisições_Internas.Domain.Features.Providers;
using Requisições_Internas.Domain.Features.Requests;
using Requisições_Internas.Domain.Features.Units;
using Requisições_Internas.Domain.Features.Users;
using Requisições_Internas.Infra.Data.Context;
using Requisições_Internas.Infra.Data.Features.Invoices;
using Requisições_Internas.Infra.Data.Features.Products;
using Requisições_Internas.Infra.Data.Features.Providers;
using Requisições_Internas.Infra.Data.Features.Requests;
using Requisições_Internas.Infra.Data.Features.Units;
using Requisições_Internas.Infra.Data.Features.Users;
using Requisições_Internas.Infra.Exports;
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
            Container.Register<IProductService, ProductService>(Lifestyle.Singleton);
            Container.Register<IUnitService, UnitService>(Lifestyle.Singleton);
            Container.Register<IUnitRepository, UnitRepository>(Lifestyle.Singleton);
            Container.Register<IProductRepository, ProductRepository>(Lifestyle.Singleton);
            Container.Register(() => new ContextInternalRequisitions(), Lifestyle.Singleton);
            Container.Register<IInvoiceService, InvoiceService>(Lifestyle.Singleton);
            Container.Register<IInvoiceRepository, InvoiceRepository>(Lifestyle.Singleton);
            Container.Register<IRequestService, RequestService>(Lifestyle.Singleton);
            Container.Register<IRequestRepository, RequestRepository>(Lifestyle.Singleton);
            Container.Register<IUserService, UserService>(Lifestyle.Singleton);
            Container.Register<IUserRepository, UserRepository>(Lifestyle.Singleton);
            Container.Register(() => new PDFExport(), Lifestyle.Singleton);

            Container.Verify();
        }
    }
}
