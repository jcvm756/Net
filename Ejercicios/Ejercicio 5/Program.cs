using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = "y";
            int sueldo = 0;
            int a = 0;
            while (res == "y" || res == "Y")
            {
                Console.WriteLine(" Calculo de sueldo");
                Console.WriteLine("------------------------");
                Console.WriteLine("Cuantos Años LLeva en la Empresa: ");
                a = Convert.ToInt32(Console.ReadLine()); 
                if(a > 10)
                {
                    sueldo = (10 * 40000) / 100;
                    Console.WriteLine(" Su sueldo sera de: " + sueldo);
                    Console.ReadLine();
                }
                else if(a < 10 && a > 5)
                {
                    sueldo = (7 * 40000) / 100;
                    Console.WriteLine(" Su sueldo sera de: " + sueldo);
                    Console.ReadLine();
                }
                else if(a < 5 && a >3)
                {
                    sueldo = (5 * 40000) / 100;
                    Console.WriteLine(" Su sueldo sera de: " + sueldo);
                    Console.ReadLine();
                }
                else if(a > 3 )
                {
                    sueldo = (3 * 40000) / 100;
                    Console.WriteLine(" Su sueldo sera de: " + sueldo);
                    Console.ReadLine();
                }
                Console.WriteLine("Desea saber realizar la operacion de nuevo? (y/n)");
                res = Console.ReadLine();
                
            }
        }
    }
}
