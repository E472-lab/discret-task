using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, y, digit, n1, n2;
            Console.WriteLine("enter first number");
            n1  = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second number");
             n2 = int.Parse(Console.ReadLine());
            num = n1;
            while (num <= n2)
            {
                digit = 0;
                for (y = 2; y < num; y++)
                {
                    if (num % y == 0)
                    {
                        digit = 1;
                        break;
                    }
                }
                if(digit==0)

                    Console.WriteLine("number:"+num);
                num++;
            }
            Console.ReadKey();
        }
    }
}
