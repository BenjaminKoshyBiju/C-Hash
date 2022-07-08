using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first no:");
            String val1 = Console.ReadLine();
            int one = Convert.ToInt32(val1);
            int i = one;
            Console.WriteLine("Enter the second no:");
                  String val2 = Console.ReadLine();
                   int two = Convert.ToInt32(val2);
            
            Console.WriteLine("The first no is "+one);
            Console.WriteLine("The second no is "+two);
            Console.WriteLine("Choose one of the operations: /,+,-,*");
            String val3 = Console.ReadLine();
            if (val3=="+")
            {
                int sum = one + two;
                Console.WriteLine("addiong both we get " + sum);
            }
            else if(val3=="-")
            {
                int sum = one - two;
                Console.WriteLine("subtracting both we get " + sum);

            }
            else if (val3 == "*")
            {
                int sum = one - two;
                Console.WriteLine("multiplying both we get " + sum);

            }
            else if (val3 == "/")
            {
                int sum = one / two;
                Console.WriteLine("dividing both we get " + sum);

            }
        }
    }
}
