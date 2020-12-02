using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiddleLayer;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Fetching Input as string from Console
                Console.WriteLine("Enter nth Number:");
                string input = Console.ReadLine();

                //Decoupling Actual Logic using Interface
                IFibonacci objIFibo;

                objIFibo = FiboFactory.GetFibonacciType(Common.FiboType.Iterative);
                int output = objIFibo.GetNthFibonacciNumber(input);

                //Sending Output to Console
                Console.WriteLine(output);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                //Logging can be implemented to log exception
                throw ex;
            }
        }
    }
}

