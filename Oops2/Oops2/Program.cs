using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops2
{
    public class Car
    {
        String col="blue"; 
       public  int speed=200;
         public String model;
        public Car()
        {
            Console.WriteLine("Enter the Model");

            model = Console.ReadLine();
             
        }
        public Car(string model, int speed)
        {
            this.speed = speed;
            this.model = model;
        }

        public void show()
        {
            Console.WriteLine("" + model + "\n" + speed);
            
          
        }
    }
    class GG
    { 
        public static void Main(string[] args)
        {
            Car car = new Car();
            Car bike = new Car("Lamorguni", 89);
            car.show();
            Console.WriteLine(car.model+""+car.speed);
            
        }
    }
}
