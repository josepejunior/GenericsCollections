using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    public interface IAtleta
    {
        string Nombre { get; set; }
        double Peso { get; set; }
        double Altura { get; set; }
    }
}
