using Requisições_Internas.Domain.Features.Units;
using Requisições_Internas.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Infra.Data.Features.Units
{
    public class UnitRepository : IUnitRepository
    {
        readonly ContextInternalRequisitions _contextInternalRequisitions;
        public UnitRepository(ContextInternalRequisitions contextInternalRequisitions)
        {
            _contextInternalRequisitions = contextInternalRequisitions;
        }
        public long Add(Unit entity)
        {
            throw new NotImplementedException();
        }

        public long Delete(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Unit> GetAll()
        {
            return _contextInternalRequisitions.Units;
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
