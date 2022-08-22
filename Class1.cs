using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Class1
    {
        static void Main(string[]args)
        {
            int ch = 0;
            do
            {
                Console.WriteLine("Enter the 1st number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the 2nd number");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the choice");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Trangle\n2.Rectangle\n3.Circle\n4.exit");
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Trangle " + (0.5*a*b ));
                        break;
                    case 2:
                        Console.WriteLine("Rectangle " + (a*b));
                        break;
                    case 3:
                        Console.WriteLine("Enter the Redious");
                        int red = int.Parse(Console.ReadLine());
                        Console.WriteLine("Circle " + (3.14*2*red*red));
                        break;
                    case 4:
                        ch = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }




            } while (ch != 0);

        }
        
    }
    
    class F
    {
        static void main (string[]args)
        {
            for (int i=1; i<=10;i++)
            {
                for (int j = 1; j <= 10; j++)
                { 
                    if (i == 1 || i == 5 || i == 10 || j==1)
                          Console.Write("*");
                    
                  else
                           Console.Write(" ");
                    
                }
                    
            }
        }
    }

}


