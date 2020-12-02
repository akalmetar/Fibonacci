using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayer
{
    //Factory Pattern
    public class FiboFactory
    {
        /// <summary>
        /// Factory Function to get object based on type
        /// </summary>
        /// <param name="type">Common Enum FiboType</param>
        /// <returns>Object of IFibonacci</returns>
        public static IFibonacci GetFibonacciType(Common.FiboType type)
        {
            IFibonacci objIFibo;

            if (type == Common.FiboType.Iterative)
                objIFibo = new FibonacciIterative();
            else if (type == Common.FiboType.Recursive)
                objIFibo = new FibonacciRecursive();
            else
                objIFibo = null;

            return objIFibo;
        }
    }
}
