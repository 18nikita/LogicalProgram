using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class reverseNumber
    {
        public static void reverseNumber1()
        {
            int n, reverse = 0, rem;
            Console.WriteLine("Enter a Number");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Reversed Number " + reverse);
        }

    }
}
