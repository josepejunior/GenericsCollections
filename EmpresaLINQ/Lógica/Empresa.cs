using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLINQ
{
    public class Empresa
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format($"Empresa {Name} con ID = {ID}");
        }
    }
}
