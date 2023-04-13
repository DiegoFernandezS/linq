using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };          // complejidad cognitiva

            for (var indice = 0; indice < valores.Count - 1; indice++)               // for -----      1   |  anidado
            {                                                                        //                    |     1
                if (valores[indice] > valores[indice + 1])                           // if  -----      1   | 
                {
                    var valorTemporal = valores[indice];

                    valores[indice] = valores[indice + 1];
                    valores[indice + 1] = valorTemporal;

                    indice = -1;
                }
            }

            foreach (var valorOrdenado in valores)                                  // foreach -----     1
            {
                Console.WriteLine(valorOrdenado);                                   // total = 4 puntos
            }


            // - - - - - - - - - - - - - - - - - -utilizando linq - - - - - - - - - - - - - - - - - - - - - - - - - 
            Console.WriteLine("");
            var valoresOrdenados = valores.OrderBy(x => x);
            foreach (var valor in valoresOrdenados)
            {
                Console.WriteLine(valor);
            }
            Console.ReadKey();
        }
    }
}
