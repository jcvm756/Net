using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Par e inpar");
            Console.WriteLine("-------------");
            Console.WriteLine(" Ingrese un nuemro: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " El Valor es Par");
            }
            else
            {
                Console.WriteLine(a + " El valor es Inpar");
            }
            Console.ReadKey();

        }
    }
}
