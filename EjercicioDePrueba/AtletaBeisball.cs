using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    public class AtletaBeisball : IAtleta
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Posicion { get; set; }
        public int JuegosIiciados { get; set; }

    }
}
