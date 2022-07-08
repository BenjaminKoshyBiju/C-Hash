using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    interface iAnimal
    {
       
        void run();
        
    }
    class Pig : iAnimal
    {
        public  void animalSound()
        {
            Console.WriteLine("pig make :meaw sound");
        }
        class Dog : iAnimal
        {
            public  void animalSound()
            {
                Console.WriteLine("Dog make woof woof sound");
            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                //Animal animal = new Animal();
                Pig pig = new Pig();
                Dog dog = new Dog();
                //  animal.animalSound();
                pig.animalSound();
                dog.animalSound();



            }
        }
    }
}
