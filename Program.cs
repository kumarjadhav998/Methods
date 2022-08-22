using System;

namespace Methods
{
    class Program
    {
        public int avgDigit(String str)
        {
            int len = str.Length;
            int num = int.Parse(str);
            int sum = 0;

            while(num>0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            return sum/len;
        }

        

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Enter the Number");

            String str = Console.ReadLine();
            Console.WriteLine("Average of digit sum = "+p.avgDigit(str));

            Console.ReadLine();




        }
    }
}
