using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int may = 0;
            int men = 0;
            Console.WriteLine(" Mayor y Menor");
            Console.WriteLine("-------------------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un valor: ");
                int val = Convert.ToInt32(Console.ReadLine());
                if(i==1)
                {
                 may=val;
                 men=val;
                }
                else if (val > may)
                {
                    may = val;
                }
                else if(val < men )
                {
                    men = val;
                }
                val = 0; 
            }
            Console.WriteLine(" El numero mas alto es: "+may+" y el numero mas Bajo es: "+men);
            Console.ReadLine();
        }
    }
}
