using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
  /*  class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
   class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "hello";
            Console.WriteLine(person.Name);
        }
    } */
    class Vehicle
    {
        public string brand = "GG Ezz";
        public void car()
        {
            Console.WriteLine(brand);
        }
    }
    class Supercar:Vehicle
    {
        public String modelname = "Noobs";
    }
    class Pro
    {
        public static void Main(String[] args)
        {
            Supercar super = new Supercar();
            super.car();
            Console.WriteLine(super.modelname);
        }
    }
}
