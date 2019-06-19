using Requisições_Internas.Application.Base;
using Requisições_Internas.Domain.Base;
using Requisições_Internas.Domain.Features.Units;
using Requisições_Internas.Infra.Exports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Application.Features.Units
{
    public class UnitService : IUnitService
    {
        IUnitRepository _unitRepository;
        public UnitService(IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }
        public long Add(Unit entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(long id)
        {
            throw new NotImplementedException();
        }

        public bool GeneratePDFReport(string filePath)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Unit> GetAll()
        {
            return _unitRepository.GetAll();
        }

        public Unit GetById(long id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Unit entity)
        {
            throw new NotImplementedException();
        }
    }
}
