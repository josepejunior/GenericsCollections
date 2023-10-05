using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    public class AtletaFutball : IAtleta
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Posicion { get; set; }
        public int GolesAnotados { get; set; }
    }
}
