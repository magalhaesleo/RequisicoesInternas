using Requisições_Internas.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Domain.Features.Units
{
    public class Unit : Entity
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
