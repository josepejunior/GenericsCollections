using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaLINQ.Datos
{
    public class ControlEmpleadoEmpresa
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;


        public ControlEmpleadoEmpresa()
        {
            listaEmpresas = new List<Empresa>()
            {
                new Empresa() {ID = 1, Name = "Nestle" },
                new Empresa() {ID = 2, Name = "CocaCola" },
                new Empresa() {ID = 3, Name = "Nestle" },
                new Empresa() {ID = 4, Name = "Nestle" }
            };
        }
    }
}
