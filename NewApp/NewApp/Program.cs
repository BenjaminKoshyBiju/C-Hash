using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ii;
            int i = Convert.ToInt32(i);
            String a, b;
            while (i != 2)
            { 
                Console.WriteLine("if you want to check for condition press 1 to exit press 2");

            
            {
                 i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the values of a and b:");
                int ch = Convert.ToInt32(Console.ReadLine());
                
            switch (ch)
                {
                case 1:
                    a = Console.ReadLine();
                    b = Console.ReadLine();
                    int one = Convert.ToInt32(a);
                    int two = Convert.ToInt32(b);
                    if (one > two)
                    {
                        Console.WriteLine(one + "is greater than" + two);
                    }
                    else if (two > one)
                    {
                        Console.WriteLine(b + "is greater than" + a);
                    }
                    else
                    {
                        Console.WriteLine("both are equal");
                    }

                    break;
                    case 2:
                    Console.WriteLine("End");
                    break;
                    default:
                        Console.WriteLine("null");
                        break;
                }
            }





        }
    }
}
