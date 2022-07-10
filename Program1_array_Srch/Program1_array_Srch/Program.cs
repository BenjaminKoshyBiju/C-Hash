using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1_array_Srch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array;
            int n, search, i;
            bool found = false;
            Console.WriteLine("Enter Array Size : ");
            n = Convert.ToInt32(Console.ReadLine());
            array = new int[n];
            if (n <= 0)
                throw new IndexOutOfRangeException();
            Console.WriteLine("Enter Array : ");
            for (i = 0; i < n; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Search Element : ");
            search = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Array :");
            for (i = 0; i < n; i++)
                Console.WriteLine(array[i]);
            for (i = 0; i < n; i++)
                if (array[i] == search)
                {
                    found = true;
                    Console.WriteLine(search + " Found at Position " + (i + 1));
                }
            if (!found)
                Console.WriteLine("...not found...");
        }
    }
}

