using Requisições_Internas.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisições_Internas.Domain.Features.Users
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Gender { get; set; }
        public DateTime Birth { get; set; }
        public string LandLine { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Group { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
    }
}
