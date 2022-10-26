using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int M, T;
            double NP, CPT,CT, G, GE;
            double MO, metro_de_tela, metros_de_tela, PF;

            //Entrada
            Console.Write("Ingresa el valor de N pantalones: ");
            NP = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de metro de tela: ");
            metro_de_tela = double.Parse(Console.ReadLine());
            Console.WriteLine("Selecciona el valor de modelo.");
            Console.WriteLine("\t1.- A");
            Console.WriteLine("\t2.- B");
            Console.Write("\t: ");
            do
            {
                M = int.Parse(Console.ReadLine());
                if (M < 1 || M > 2)
                    Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
            } while (M < 1 || M > 2);
            Console.WriteLine("Selecciona el valor de talla.");
            Console.WriteLine("\t1.- 30");
            Console.WriteLine("\t2.- 32");
            Console.WriteLine("\t3.- 36");
            Console.Write("\t: ");

            //Proceso y salida
            do
            {
                T = int.Parse(Console.ReadLine());
                if (T < 1 || T > 3)
                    Console.Write("Valor incorrecto. Ingr\u00E9salo nuevamente.: ");
            } while (T < 1 || T > 3);
            if (M == 1)
                metros_de_tela = 1.5 * NP;
            else
                metros_de_tela = 1.8 * NP;
            CT = metros_de_tela * metro_de_tela;
            if (M == 1)
                MO = CT * 0.80;
            else
                MO = CT * 0.95;
            if (T == 2 || T == 3)
                CPT = MO * 0.04;
            else
                CPT = 0;
            GE = (CT + MO + CPT) * 0.3;
            PF = CT + MO + CPT + GE;
            G = CPT + GE;
            Console.WriteLine("Valor de cargo por talla: " +CPT);
            Console.WriteLine("Valor de costo de la tela: " + CT);
            Console.WriteLine("Valor de ganancia: " +G);
            Console.WriteLine("Valor de ganancia extra: " + GE);
            Console.WriteLine("Valor de mano de obra: " + MO);
            Console.WriteLine("Valor de metros de tela: " + metros_de_tela);
            Console.WriteLine("Valor de precio final: " + PF);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
