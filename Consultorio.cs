using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisio_consultorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            int NC, CC = 0, CT = 0;

            //Entrada
            Console.WriteLine("Consultorio");
            Console.WriteLine("Ingresa el valor de numero de cita: ");
            NC = int.Parse(Console.ReadLine());

            //Proceso
            if (NC >= 1 && NC <= 3)
            {
                CC = 200;
                CT = NC * 200;
            }
            if (NC >= 4 && NC <= 5)
            {
                CC = 150;
                CT = (NC - 3) * 150 + 600;
            }
            if (NC >= 6 && NC <= 9)
            {
                CC = 100;
                CT = (NC - 5) * 100 + 900;
            }
            if (NC >= 10)
            {
                CC = 50;
                CT = (NC - 8) * 50 + 1200;
            }
            Console.WriteLine("Valor de monto que ha pagado:" + CT);
            Console.WriteLine("Valor de pago por la cita: " + CC);
            Console.ReadKey();
        }
    }
}
