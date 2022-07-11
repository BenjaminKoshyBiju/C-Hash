using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadAndWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String writeText = "Hello Ben";
            File.WriteAllText("C:/Users/91623/Desktop/Read.txt",writeText);// we will write the file with string varaible write text using this syntax
            String readText = File.ReadAllText("C:/Users/91623/Desktop/Read.txt");//for reading
            Console.WriteLine(readText);


        }
    }
}
