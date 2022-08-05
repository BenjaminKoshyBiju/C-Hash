using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_cases
{
    
    internal class Program
    { 
        static void Main(string[] args)
        {// simple array using simple for loop
             void checkAge(int age)
            {
                if (age < 18)
                {
                    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
                }
                else
                {
                    Console.WriteLine("Access granted - You are old enough!");
                }
            }
            checkAge(199);
            int i = 0;
            string[] cars = { "volvo", "merci", "audi" };
            //sorting
          //  Array.Sort(cars);
        //   for(  i=0;i<cars.Length;i++)
          //  Console.WriteLine(cars[i]);
            // using foreach
            int[] model = { 1, 2, 3 };
         //   foreach (int mod in model)
            {
          //      Console.WriteLine(mod);
            }
            //Looping while
            
            Console.WriteLine("This is while Loop");
            while( i<cars.Length&&i<=model.Length)
            {
                Console.WriteLine(cars[i]+model[i]);
              //  Console.Write(model[i]);
               i++;
            }
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
