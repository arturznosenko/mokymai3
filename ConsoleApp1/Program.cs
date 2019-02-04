using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 3 skaicius");
            int skaicius1 = Convert.ToInt32(Console.ReadLine());
            int skaicius2 = Convert.ToInt32(Console.ReadLine());
            int skaicius3 = Convert.ToInt32(Console.ReadLine());

            int maxnum = max(skaicius1, skaicius2, skaicius3);
            Console.WriteLine(maxnum);

            Console.ReadLine();
        }

        static int max (int a, int b, int c)
        {
            int number = 0;
            if ((a>b) && (a>c))
                    {
                number = a;
            }
            else if (b>c)
            {
                number = b;
            }
            else
            {
                number = c;
            }
            return number;
        }
    }
}
