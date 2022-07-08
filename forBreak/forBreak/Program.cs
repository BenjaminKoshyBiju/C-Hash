using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 10;
            for (int i = 0; i < m; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
                if (i == 4)
                {
                    break;
                }

            }
            string[] arr = {}
          

        }
    }
}
