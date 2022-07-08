using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mynumbers = {1,2,3};
            try
            {
                Console.WriteLine("" + mynumbers[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "\n Error Occured");
            }
        }
    }
}
