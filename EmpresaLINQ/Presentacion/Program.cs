using EmpresaLINQ.Datos;

ControlEmpleadoEmpresa controlEmpleadoEmpresa = 
    new ControlEmpleadoEmpresa();

Console.WriteLine("Obteniendo empleados con cargo CEO");
controlEmpleadoEmpresa.ObtenerCargo("CEO");

Console.WriteLine("\nObteniendo empleados con salario mayor a 1000");
controlEmpleadoEmpresa.ObtenerSalario(1000);

Console.WriteLine("\nObteniendo empleados de empresa NESTLE");
controlEmpleadoEmpresa.ObtenerEmpleadosEmpresa("NESTLE");