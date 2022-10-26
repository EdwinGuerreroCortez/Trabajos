using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_adicional
{
    internal class Program
    {
        public static double fact(double num1)
        {
            if (num1 == 0 || num1 == 1)
                return 1;
            return num1 * fact(num1 - 1);
        }
        static void Main(string[] args)
        {
            //Declarar variables
            char opcion, operador = ' ';
            //Declarando e inicializando variables
            //se asigna el valor de 0 a las variables
            double num1 = 0, num2 = 0, resultado = 0;
            Console.WriteLine("Calculadora adicional");
            Console.WriteLine("Selecciona una opcion:");
            Console.WriteLine("Z-Suma");
            Console.WriteLine("G-Resta");
            Console.WriteLine("V-Division");
            Console.WriteLine("K-Multiplicacion");
            Console.WriteLine("P-Potencia");
            Console.WriteLine("R-Raiz cuadrada");
            Console.WriteLine("E-elevado al cuadrado");
            Console.WriteLine("X-Elevado al cubo");
            Console.WriteLine("B-Raiz Elevado al");
            Console.WriteLine("C-Coseno");
            Console.WriteLine("S-Seno");
            Console.WriteLine("T-Tangente");
            Console.WriteLine("L-Logaritmo natural");
            Console.WriteLine("I-Inversa del logaritmo");
            Console.WriteLine("M-Mod");
            Console.WriteLine("N-Redondear");
            Console.WriteLine("J-Porcentaje");
            Console.WriteLine("F-Factorial");
            Console.WriteLine("Selecciona una opcion: ");
            opcion = char.Parse(Console.ReadLine());
            if (opcion == 'R' || opcion == 'r' || opcion == 'E' || opcion == 'e' || opcion == 'X' || opcion == 'x' || opcion == 'C' ||
                opcion == 'c' || opcion == 'I' || opcion == 'i' || opcion == 'N' || opcion == 'n' ||
                opcion == 'S' || opcion == 's' || opcion == 'T' || opcion == 't' || opcion == 'L' || opcion == 'l' || opcion == 'F' || opcion == 'f')
            {
                Console.WriteLine("Ingresa el primer numero:");
                num1 = double.Parse(Console.ReadLine());
                //realiza la operacion segun la opcion
                switch (opcion)
                {
                    case 'E':

                        resultado = Math.Pow(num1, 2);
                        operador = '^';
                        break;

                    case 'R':
                        resultado = Math.Sqrt(num1);
                        operador = '√';
                        break;
                    case 'X':

                        resultado = Math.Pow(num1, 3);
                        operador = '^';
                        break;

                    case 'C':
                        resultado = Math.Cos(num1);
                        operador = '^';
                        break;
                    case 'S':

                        resultado = Math.Sin(num1);
                        operador = '^';
                        break;
                    case 'T':

                        resultado = Math.Tan(num1);
                        operador = '^';
                        break;
                    case 'I':

                        resultado = Math.Log(num1);
                        operador = '^';
                        break;
                    case 'L':

                        resultado = Math.Log10(num1);
                        operador = '^';
                        break;
                    case 'N':

                        resultado = Math.Round(num1);
                        operador = '^';
                        break;
                    case 'F':

                        resultado = num1 * fact(num1 - 1);
                        operador = '!';
                        break;
                }
                //salida
                resultado = Math.Round(resultado, 3);
                Console.WriteLine(operador + " " + num1 + "=" + resultado);
            }
            else
            {
                if (opcion == 'M' || opcion == 'm' || opcion == 'Z' || opcion == 'z' || opcion == 'J' || opcion == 'j'
                 || opcion == 'G' || opcion == 'g' || opcion == 'V' || opcion == 'v' || opcion == 'K' || opcion == 'k'
                 || opcion == 'P' || opcion == 'p' || opcion == 'B' || opcion == 'b')
                {
                    Console.WriteLine("Ingresa el primer numero:");
                    num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero:");
                    num2 = double.Parse(Console.ReadLine());
                    //realiza la operacion segun la opcion
                    switch (opcion)
                    {
                        case 'J':

                            resultado = (num1 / 100) * num2;
                            operador = '%';
                            break;
                        case 'Z':

                            resultado = num1 + num2;
                            operador = '+';
                            break;
                        case 'G':

                            resultado = num1 - num2;
                            operador = '-';
                            break;
                        case 'V':

                            resultado = num1 / num2;
                            operador = '/';
                            break;
                        case 'K':

                            resultado = num1 * num2;
                            operador = '*';
                            break;
                        case 'P':

                            resultado = Math.Pow(num1, num2);
                            operador = '^';
                            break;
                        case 'B':

                            resultado = Math.Pow(num1, 1 / num2);
                            operador = '√';
                            break;
                        case 'M':

                            resultado = num1 % num2;
                            operador = '%';
                            break;
                    }
                    //salida
                    resultado = Math.Round(resultado, 3);
                    Console.WriteLine(num1 + " " + operador + " " + num2 + " " + "=" + resultado);
                }
                else
                {
                    Console.WriteLine("Verificar la opcion: ");
                }
                Console.ReadKey();
            }
        }
    }
}
