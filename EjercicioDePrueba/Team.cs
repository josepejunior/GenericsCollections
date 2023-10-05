using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team;

namespace Team
{
    public class Team<T> where T : IAtleta
    {
        public string NombreCoach { get; set; }

        public T[] Miembros { get; set; }

        public Team(int maxMiembros)
        {
            Miembros = new T[maxMiembros];
        }
    }
}
