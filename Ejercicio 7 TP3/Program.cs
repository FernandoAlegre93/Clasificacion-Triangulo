using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_7_TP3
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B ,C;
           
                Console.WriteLine("Ingrese el Lado A");
                A = Convert.ToInt32 (Console.ReadLine());
                Console.WriteLine("Ingrese el Lado B");
                B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el Lado C");
                C = Convert.ToInt32(Console.ReadLine());

                if (A == B & B == C & A == C)
                {
                    Console.WriteLine("El triangulo es equilatero");
                }
                else if
                    (A != B & B != C & A != C)
                {
                    Console.WriteLine("El triangulo es Escaleno");
                }
                else if
                    (A != B || B != C || A != C)
                {
                    Console.WriteLine("El triangulo es Isoceles");
                }

                
    
         Console.ReadKey();


        }
    }
}
