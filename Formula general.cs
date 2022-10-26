using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_general
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            Double A, B, C, Y, X1=0, X2=0;

            //Entrada
            Console.WriteLine("Formula genral");
            Console.WriteLine("Valor de A:");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de B:");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de C:");
            C = double.Parse(Console.ReadLine());

            //Proceso
            Y = (B * B) - (4 * A * C);
            if (Y >= 0)
            {
                X1 = (B + (Math.Sqrt((Math.Pow(B, 2)) - (4 * A * C)))) / (2 * A);
                X2 = (B - (Math.Sqrt((Math.Pow(B, 2)) - (4 * A * C)))) / (2 * A);
                Console.WriteLine("X1 es: " + X1);
                Console.WriteLine("X2 es: " + X2);
            }
            else
            {
              
                Console.WriteLine("Error");
            }
            
            Console.ReadKey();
        }
    }
}
