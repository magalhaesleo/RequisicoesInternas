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
        bool GeneratePDFReport(DateTime initialDate, DateTime finalDate, Domain.Object_Values.Status status, string filePath);
        bool GeneratePDFReport(DateTime value1, DateTime value2, string fileName);
    }
}
