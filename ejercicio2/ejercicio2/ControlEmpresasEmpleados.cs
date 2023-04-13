using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados() {

            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();
            
            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "IAlpha" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Udelar" });
            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "SpaceZ" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaID = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "JuanC", Cargo = "Desarrollador", EmpresaID = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "JuanR", Cargo = "Desarrollador", EmpresaID = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Daniel", Cargo = "Desarrollador", EmpresaID = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaID = 2, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Leonardo", Cargo = "CEO", EmpresaID = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaID = 3, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Leonardo", Cargo = "CEO", EmpresaID = 3, Salario = 3000 });
        }

        public void GetSeo(string _Cargo)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              where empleado.Cargo == _Cargo
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.GetDatosEmpleado();
            }
        }

        public void GetEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.Nombre
                                              select empleado;
            foreach(Empleado elemento in empleados)
            {
                elemento.GetDatosEmpleado();
            }
        }

        public void GetEmpleadosOrdenadosSegun()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.Salario
                                              select empleado;

            foreach(Empleado elemento in empleados)
            {
                elemento.GetDatosEmpleado();
            }
        }

        public void GetEmpleadosEmpresa(int _Empresa)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              join empresa in listaEmpresas on empleado.EmpresaID
                                              equals empresa.Id
                                              where empresa.Id == _Empresa
                                              select empleado;

            foreach(Empleado elemento in empleados)
            {
                elemento.GetDatosEmpleado();
            }
        }

        public void promedioSalario()
        {
            var consulta = from e in listaEmpleados
                           group e by e.EmpresaID into g
                           select new { empresa = g.Key, PromedioSalario = g.Average(e => e.Salario) };

            foreach(var resultado in consulta)
            {
                switch (resultado.empresa)
                {
                    case 1: Console.WriteLine($"Empresa IAlpha - Promedio de Salario: { resultado.PromedioSalario}");
                    break;
                    case 2: Console.WriteLine($"Empresa Udelar - Promedio de Salario: {resultado.PromedioSalario}");
                    break;
                    case 3: Console.WriteLine($"Empresa SpaceZ - Promedio de Salario: {resultado.PromedioSalario}");
                    break;
                }
            }
        }

    }
}
