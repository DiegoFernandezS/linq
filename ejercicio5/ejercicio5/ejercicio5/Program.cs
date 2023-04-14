using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int sumaTotalValoresParesMayoresAOcho = 0;
            int sumaTotalValoresParesMenoresAOcho = 0;

            foreach (var valor in valores)                                  //  Comlejidad cognitiva 
            {
                if (valor % 2 == 0 && valor > 8)                            //  antes 6 puntos --- ahora 5 puntos
                {   
                    sumaTotalValoresParesMayoresAOcho += valor;             // (se elimino un if)
                }

                if (valor % 2 == 0 && valor < 8)
                {
                    sumaTotalValoresParesMenoresAOcho += valor;
                }
            }



            Console.WriteLine($"La suma total de los valores mayores a ocho es: {sumaTotalValoresParesMayoresAOcho}");
            Console.WriteLine($"La suma total de los valores menores a ocho es: {sumaTotalValoresParesMenoresAOcho}");



            //-----------------------------  utilizando linq ---------------------------------------------------------

            var valoresMayoresAOcho = valores.Where(valor => valor % 2 == 0).Where(valor => valor > 8).ToList();
            var valoresMenoresAOcho = valores.Where(valor => valor % 2 == 0).Where(valor => valor < 8).ToList();

            var sumaMayores = valoresMayoresAOcho.Sum();
            var sumaMenores = valoresMenoresAOcho.Sum();

            Console.WriteLine("La suma de los mayores a ocho (utilizando linq): " + sumaMayores);
            Console.WriteLine("La suma de los menores a ocho (utilizando linq): " + sumaMenores);

            Console.ReadKey();
        }
    }
}
