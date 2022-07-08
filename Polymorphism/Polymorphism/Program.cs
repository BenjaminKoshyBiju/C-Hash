using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    abstract class  Animal
    {
        public abstract void animalSound();
       // {
         //   Console.WriteLine("The animal makes a sound:");

    //        }
    public void sleep()
        {
            Console.WriteLine("sleepyyyy");
        }
    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("pig make :meaw sound");
        }
        class Dog : Animal
        {
            public override void animalSound()
            {
                Console.WriteLine("Dog make woof woof sound");
            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                //Animal animal = new Animal();
                Animal pig = new Pig();
                Animal dog = new Dog();
              //  animal.animalSound();
                pig.animalSound();
                pig.sleep();
                dog.animalSound();
                


            }
        }
    }
}
