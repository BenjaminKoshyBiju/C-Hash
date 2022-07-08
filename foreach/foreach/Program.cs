using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Disp(int a,String b)
        {
            Console.WriteLine("Im" + b + "im" + a);
    }

        public  void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };

            String[] s = { "Ben", "addd0, };

            foreach (int n in array)
            {
                Console.WriteLine(n);
            }





        }
    }
