using System;
namespace ConsoleApplication1
{

    enum day
    {

        mon,
        tue,
        wed,
        thurs,
        fri

    }

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("The value of Mon in day " +
                              "enum is " + (int)day.mon);
            Console.WriteLine("The value of Tue in day " +
                              "enum is " + (int)day.tue);
            Console.WriteLine("The value of Wed in day " +
                              "enum is " + (int)day.wed);
            Console.WriteLine("The value of Thursday in day " +
                              "enum is " + (int)day.thurs);
            Console.WriteLine("The value of Friday in day " +
                              "enum is " + (int)day.fri);
        }
    }
}
