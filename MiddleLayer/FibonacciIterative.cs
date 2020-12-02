using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayer
{
    public class FibonacciIterative : IFibonacci
    {
        /// <summary>
        /// Function to Validate Input and get nth Fibonacci
        /// </summary>
        /// <param name="input">nth Fibonacci number as string</param>
        /// <returns>integer</returns>
        public int GetNthFibonacciNumber(string input)
        {
            try
            {
                int n;

                //validating input string
                if (!Common.isStringValidInteger(input))
                    throw new Exception("Enter Valid Input");
                else
                {
                    n = Convert.ToInt32(input);
                    n = n - 1;

                    int[] FiboArray = new int[n + 1];

                    FiboArray[0] = 0;
                    FiboArray[1] = 1;

                    for (int i = 2; i <= n; i++)
                    {
                        FiboArray[i] = FiboArray[i - 2] + FiboArray[i - 1];
                    }

                    return FiboArray[n];
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
