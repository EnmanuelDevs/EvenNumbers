using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 2;
            Console.WriteLine("Even Numbers from 1 to 100:");

            while (number <= 100)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                number ++;
            }

            Console.ReadKey();
        }
    }
}
