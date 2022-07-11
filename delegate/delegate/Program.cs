using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//multicasting of delegates
namespace @delegate
{
    class Rectangle
    {
        public delegate void rectDelegate(double height, double width);
        
        public void area(double height, double width)
        {
            Console.WriteLine("Area is:{0}",width*height);
        }
        public void perimeter(double height,double width)
        {
               Console.WriteLine("Perimeter is:{0}",2*width+height);
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rectDelegate rectDel = new rectDelegate(rect.area);//using standard method we have to manually call each fn but with delegate we can call all of them in one go.
            rectDel += rect.perimeter;
            rectDel.Invoke(3, 5);
           }
    }



    
    
       
    
}
