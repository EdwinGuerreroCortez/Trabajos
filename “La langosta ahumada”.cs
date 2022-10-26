using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_clase_3z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int CP,T, P = 0;

            //Entrada
            Console.WriteLine("Presupuesto banquete");
            Console.WriteLine("Escribe la cantidad de personas");
            CP = int.Parse(Console.ReadLine());

            //Proceso
            if (CP > 300)
            {
                P = 75;
            }
            else
            {
                if (CP > 200 && CP <= 300)
                {
                    P = 85;
                }
 
             else
            {
                    P = 95;
                }
            }
            T = CP * P;
            Console.WriteLine("El total final es:" + T);
            Console.ReadKey();

        }
    }
}
