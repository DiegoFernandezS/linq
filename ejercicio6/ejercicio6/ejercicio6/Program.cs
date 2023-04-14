using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una letra minuscula (desde a hasta f) para saber cual es la siguiente letra del abecedario!!");
            string letra = Console.ReadLine();

            if(letra == "a")                                                                        // complejidad cognitiva
            {
                Console.WriteLine("La siguiente letra del abecedario es la B !!");                  //  1
            }

            if (letra == "b")
            {
                Console.WriteLine("La siguiente letra del abecedario es la C !!");                  //  1
            }

            if (letra == "c")
            {
                Console.WriteLine("La siguiente letra del abecedario es la D !!");                  //  1
            }

            if (letra == "d")
            {
                Console.WriteLine("La siguiente letra del abecedario es la E !!");                  //  1
            }

            if (letra == "e")
            {
                Console.WriteLine("La siguiente letra del abecedario es la F !!");                  //  1
            }

            if (letra == "f")
            {
                Console.WriteLine("La siguiente letra del abecedario es la G !!");                  //  1
            }
                                                                                                    // total 6 puntos



            // -------------------------------- disminucion --------------------------------------------------------


            Console.ReadKey();
        }                                                                                           
    }
}
