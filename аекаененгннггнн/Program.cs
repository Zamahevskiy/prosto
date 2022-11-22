 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace аекаененгннггнн
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b;
            int c = 0;

            Console.WriteLine("Введите результат: ");

            

            while(a == 0)
            {
                b = Convert.ToInt32(Console.ReadLine());

                if (b > c)

                {

                    Console.WriteLine("Лучший результат: " + b);
                    c = b;
                }

                else

                {

                    Console.WriteLine("Лучший результат: " + c);
                    
                }
            }

            Console.ReadLine();

        }
    }
    
}
