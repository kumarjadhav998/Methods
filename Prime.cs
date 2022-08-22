using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Prime
    {
        public void isPrime(int num)
        {
            bool flag = false;
            int i = 2;
            while (num > i)
            {
                if (num % i == 0)
                {
                    flag = true;
                    break;
                }
                i++;
            }
            if (flag)
                Console.WriteLine(num + " is not prime");
            else
                Console.WriteLine( num + " is prime");
        }

        public static void main(String [] args)
        {
            Prime p = new Prime();

            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            p.isPrime(num);
        }
    }
}
