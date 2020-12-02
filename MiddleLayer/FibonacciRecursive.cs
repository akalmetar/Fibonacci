using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayer
{
    public class FibonacciRecursive:IFibonacci
    {
        /// <summary>
        /// Function to Validate Input and get nth Fibonacci
        /// </summary>
        /// <param name="input">nth Fibonacci number as string</param>
        /// <returns>integer</returns>
        public int GetNthFibonacciNumber(string input)
        {
            try {
                int n;

                //validating input string
                if (!Common.isStringValidInteger(input))
                    throw new Exception("Enter Valid Input");
                else
                    n = Convert.ToInt32(input);

                return GetNthFibonacci(n - 1);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Function to get nth Fibonacci
        /// </summary>
        /// <param name="n">nth Fibonacci number as integer</param>
        /// <returns>integer</returns>
        private int GetNthFibonacci(int n)
        {
            if ((n == 0) || (n == 1))
                return n;
            else
                return GetNthFibonacci(n - 1) + GetNthFibonacci(n - 2);
        }
    }
}
