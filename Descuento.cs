using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int P, PCD = 0, DESC = 0;

            //Entrada
            Console.WriteLine("Descuento");
            Console.WriteLine("Precio del articulo ");
            P = int.Parse(Console.ReadLine());

            //Proceso
           
            if (P >= 200)
            {
                DESC = (P * 15) / 100;
                PCD = P - DESC; 
                Console.WriteLine("Descuento es:" + DESC);
                Console.WriteLine("Pago con descuento es: " + PCD);
            }
            else
            if (P > 100 && P < 200)
            {
                DESC = (P * 12) / 100;
                PCD = P - DESC;
                Console.WriteLine("Descuento es:" + DESC);
                Console.WriteLine("Pago con descuento es: " + PCD);
            }
            else
            if (P <= 100 && P >= 1)
            {
                DESC = (P * 10) / 100;
