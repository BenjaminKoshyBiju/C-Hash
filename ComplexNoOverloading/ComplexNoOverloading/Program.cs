using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Collections;



namespace ComplexNoOverloading
{

    namespace ErrorHandlingApplication
    {
        public class PrivateAssembly
        {
            /// <summary>  
            /// return ADDITION result of number1 + number2  
            /// </summary>  
            /// <param name="number1"></param>  
            /// <param name="number2"></param>  
            /// <returns></returns>  
            public int Addition(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }
            /// <summary>  
            /// return SUBTRACT result of number1 - number2  
            /// </summary>  
            /// <param name="number1"></param>  
            /// <param name="number2"></param>  
            /// <returns></returns>  
            public int Subtraction(int number1, int number2)
            {
                int result = number1 - number2;
                return result;
            }

        }
    }

}

