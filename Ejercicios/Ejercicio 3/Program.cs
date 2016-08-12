using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Orden Creciente");
            Console.WriteLine("--------------------");
            Console.WriteLine(" ingrese Valor 1:");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" Orden Creciente");
            Console.WriteLine("--------------------");
            Console.WriteLine(" ingrese Valor 2:");
            int val2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(" Orden Creciente");
            Console.WriteLine("--------------------");
            Console.WriteLine(" ingrese Valor 3:");
            int val3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (val1 < val2 && val1 < val3 && val2 > val1 && val2 < val3 && val3 > val1 && val3 > val2)
            {
                Console.WriteLine(" Se Ingreso de forma Creciente");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" No se Ingreso de forma creciete");
                Console.ReadLine();
            }
            
        }
    }
}
