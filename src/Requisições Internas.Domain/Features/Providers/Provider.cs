using Requisições_Internas.Domain.Base;
using Requisições_Internas.Domain.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Domain.Features.Providers
{
    public class Provider : Entity
    {
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string Telephone { get; set; }
        public Enabled Enabled { get; set; }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                throw new Exception("O nome não pode ser vazio");
        }
    }
}
