using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Dias de la Semana");
            Console.WriteLine("------------------");
            Console.WriteLine(" Escriba un Nuemro: ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b > 7 || b < 1)
            {
                Console.WriteLine(" El valor ingresado no Corresponde a ningun Dia");
                Console.ReadLine();
            }
            else
            {
                switch (b)
                {
                    case 1:
                        Console.WriteLine(" EL Valor ingresado corresponde a Domingo");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(" EL Valor ingresado corresponde a Lunes");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine(" EL Valor ingresado corresponde a Martes");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine(" EL Valor ingresado corresponde a Miercoles");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine(" EL Valor ingresado corresponde a Jueves");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine(" EL Valor ingresado corresponde a Viernes");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine(" EL Valor ingresado corresponde a Sabado");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
