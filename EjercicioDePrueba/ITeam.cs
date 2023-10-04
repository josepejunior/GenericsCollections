using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePrueba
{
    public interface ITeam
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
    }
}
