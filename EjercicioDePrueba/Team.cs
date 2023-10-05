using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioDePrueba;

namespace EjercicioDePrueba
{
    public class Team
    {
        public string CoachName { get; set; }
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Posicion {  get; set; }
        public int GolesOjuegos {  get; set; }

        public Team(string coachName, string nombre, double peso, double altura, string posicion, int golesOjuegos)
        {
            CoachName = coachName;
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Posicion = posicion;
            GolesOjuegos = golesOjuegos;
        }


        public void GetAtletas()
        {

        }
    }
}
