using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables 
            int a, b;

            //Entrada
            Console.WriteLine("Ejemplo 3.1 - uso del if");
            Console.WriteLine("Programa para obtener el mayor de 2 numeros");
            Console.WriteLine("Escribe el primer numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el segundo numero");
            b = int.Parse(Console.ReadLine());

            //Proceso de comparacion y salida
            if (a > b)
                Console.WriteLine("El valor mayor es:" + a);
            if (a < b)
                Console.WriteLine("El valor mayor es:" + b);
            if (a == b)
                Console.WriteLine("Los valores son iguales");

            Console.ReadKey();


        }
    }
}
