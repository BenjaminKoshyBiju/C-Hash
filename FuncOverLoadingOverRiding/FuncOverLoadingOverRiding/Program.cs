using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncOverLoadingOverRiding
{
    class Functions
    {
        int a, b;
        public void f1()
        {
            Console.WriteLine("This is first fn");

        }
        public void f1(int a)
        {
            Console.WriteLine("Second fn");
        }
        public void f1(int a, int b)
        {
            Console.WriteLine("3rd Function");
        }
    }
    class Afunc: Functions
        {
            public void f1(int a,int b)
        {
            Console.WriteLine("Alternate to 3rd function");
        }
        }

    internal class Program
    {
   
        static void Main(string[] args)
        {
            Functions ob1 = new Functions();
            Afunc ob2 = new Afunc();
            ob1.f1();
            ob1.f1(1);
           // ob1.f1(2,4);
            ob2.f1(3, 2);

        }
    }

}
