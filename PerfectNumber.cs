using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public static void perfectNumber1()
        {
            int number, sum = 0, n;
            Console.WriteLine("Enter a Number");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Entered number is perfect");
            }
            else
            {
                Console.WriteLine("Entered number is not perfect");

            }
        }
    
}
}
