using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public static void CouponNumber1()
        {
            int i;
            int randomCount = 0;
            int ran = 0;
            Console.WriteLine("Enter no of distinct coupon numbers");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intDistinct = new int[n];
            for (i = 0; i < n; i++)
            {
                intDistinct[i] = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    randomCount++;
                    Random random = new Random();
                    ran = random.Next(0, 11);
                    if (ran == intDistinct[i])
                    {
                        Console.WriteLine("Random count:" + randomCount);
                        break;
                    }
                }
            }
        }
    }
}
