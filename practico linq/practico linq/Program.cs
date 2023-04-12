using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona {Nombre = "Juan", Edad = 25, Ciudad = "Lima"},
                new Persona {Nombre = "Maria", Edad = 30, Ciudad = "Bogota"},
                new Persona {Nombre = "Pedro", Edad = 35, Ciudad = "Madrid"},
                new Persona {Nombre = "Ana", Edad = 20, Ciudad = "Lima"},
                new Persona {Nombre = "Jose", Edad = 40, Ciudad = "Buenos Aires"},
            };

            var consulta = from p in personas
                           where p.Edad < 25 && p.Ciudad == "Lima"
                           orderby p.Nombre descending
                           select new { p.Nombre, p.Edad };

            foreach (var persona in consulta)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }

            // --------------------punto i)
            var consultaI = from p in personas
                           where p.Edad > 30 && p.Ciudad == "Bogota"
                           orderby p.Nombre descending
                           select new { p.Nombre, p.Edad };

            foreach (var persona in consultaI)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }

            // --------------------punto ii)
            var consultaII = from p in personas
                            where (p.Edad >= 25 && p.Edad <= 35)
                            orderby p.Edad ascending
                            select new { p.Nombre, p.Edad };

            foreach (var persona in consultaII)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }



            Console.ReadKey();
        }
    }
}
