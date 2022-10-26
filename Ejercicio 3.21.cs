using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double CR, GPI, I, M, PCA;
            double PG, PPNGI, SA, S_ANTERIOR;
            GPI = 0;
            
            //ENTRADA
            Console.Write("Ingresa el valor de n: ");
            n = int.Parse(Console.ReadLine());

            //PROCESO Y SALDA
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("PROCESO " + i);
                Console.Write("Ingresa el valor de compras realizadas: ");
                CR = double.Parse(Console.ReadLine());
                Console.Write("Ingresa el valor de pago del corte anterior: ");
                PCA = double.Parse(Console.ReadLine());
                Console.Write("Ingresa el valor de saldo anterior: ");
                S_ANTERIOR = double.Parse(Console.ReadLine());
                if (S_ANTERIOR * 0.15 > PCA)
                {
                    I = S_ANTERIOR * 0.12;
                    M = 200;
                }
                else
                {
                    I = 0;
                    M = 0;
                }
                SA = S_ANTERIOR + CR - PCA + I + M;
                PG = SA * 0.15;
                PPNGI = SA * 0.85;
                GPI = GPI + I;

                Console.WriteLine("Valor de intereses: " + I);
                Console.WriteLine("Valor de multa: " + M);
                Console.WriteLine("Valor de pago minimo: " + PG);
                Console.WriteLine("Valor de pago para no generar intereses: " + PPNGI);
                Console.WriteLine("Valor de saldo actual: " + SA);
                Console.WriteLine();
            }
            Console.WriteLine("Valor de ganacia por intereses: " + GPI);
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        
    }
    }
}
