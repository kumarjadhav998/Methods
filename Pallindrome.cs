using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Pallindrome
    {
        public void isPallindrome(int num)
        {
            int rev = 0;
            while(num>0)
            {
                rev = rev * 10;
                int rem = num % 10;
                rev = rev + rem;
                num = num / 10;
            }

            if (num == rev)
                Console.WriteLine("Pallindrome ");
            else
                Console.WriteLine("Not Pallindrome");
        }

        public static void main(String[] args)
        {
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            Pallindrome p = new Pallindrome();
            p.isPallindrome(num);
        }
    }
}
