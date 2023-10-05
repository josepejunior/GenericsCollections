using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDePrueba;

namespace EjercicioDePrueba
{
    public class Team<T> : ITeam
    {
        public string CoachName { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        private Object[] DatosAtletas;

        private int i = 0;

        public Team(string coachName, string nombre, double peso, double altura)
        {
            CoachName = coachName;
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
        }

        public Team(int x)
        {
            DatosAtletas = new Object[x];
        }

        public void Agregar(Object atleta)
        {
            DatosAtletas[i] = atleta;
            i++;
        }

        public Object GetAtletas()
        {
            return DatosAtletas;
        }
    }
}
