using Requisições_Internas.Application.Base;
using Requisições_Internas.Domain.Features.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Application.Features.Requests
{
    public interface IRequestService : IService<Request>
    {
    }
}
