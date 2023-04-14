using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sumaTotal = 0;

            foreach(var valor in valores)
            {
                sumaTotal += valor;
            }

            Console.WriteLine($"La suma total es: {sumaTotal}");

            List<int> valores2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sumaTotalValoresPares = 0;

            foreach (var valor in valores2)
            {
                if(valor % 2 == 0)
                {
                    sumaTotalValoresPares += valor;
                }
            }

            Console.WriteLine($"La suma total de los valores pares es: {sumaTotalValoresPares}");

            

            //------------------------------------------- utilizando linq -----------------------------------------------

            var suma = valores.Sum();
            Console.WriteLine("La suma total (Utilizando linq): " + suma);

            var pares = valores.Where(valor => valor % 2 == 0).ToList();
            var suma2 = pares.Sum();
            Console.WriteLine("La suma de los valores pares (Utilizando linq): " + suma2);
            Console.ReadKey();
        }
    }
}
