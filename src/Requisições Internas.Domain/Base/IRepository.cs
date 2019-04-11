using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Domain.Base
{
    public interface IRepository<T> where T : Entity
    {
        long Add(T entity);
        T GetById(long id);
        bool Update(T entity);
        long Delete(long id);
        IEnumerable<T> GetAll();
    }
}
