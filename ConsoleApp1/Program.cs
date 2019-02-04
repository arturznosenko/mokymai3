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
            bool rangeyes = inrange(skaicius1, skaicius2, skaicius3);
            bool rangeyes2 = inrange2(skaicius1, skaicius2, skaicius3);

            Console.WriteLine(maxnum);
            Console.WriteLine(rangeyes);
            Console.WriteLine(rangeyes2);

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
        static bool inrange (int a, int b, int c)
        {
            bool range = false;
            if ((a > b) && (a > c))  // if (a>b && a<c)
            {
                range = false;
            }
            else if ((a < b) && (a < c))
            {
                range = false;
            }
            else
            {
                range = true;
            }
            return range;
        }

        static bool inrange2 (int a, int b, int c)
        {
            bool range2 = false;
            if (a > b && a < c)
            {
                range2 = true;
            }
            else
            {
                range2 = false;
            }
            return range2;

        }
    }
}
