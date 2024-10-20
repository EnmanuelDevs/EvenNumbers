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
            Console.WriteLine("Even Numbers from 1 to 100:");

            int number = 2;

            while (number <= 100)
            {
                Console.WriteLine(number);
                number += 2;
            }

            Console.ReadKey();
        }
    }
}
