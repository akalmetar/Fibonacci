using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiddleLayer;

namespace TestProj
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CheckFiboIterative()
        {
            string input = "11";

            IFibonacci objIFibo;

            objIFibo = FiboFactory.GetFibonacciType(Common.FiboType.Iterative);
            int output = objIFibo.GetNthFibonacciNumber(input);


            Assert.IsNotNull(output);
            Assert.AreEqual(55, output);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void CheckInvalidStringIterative()
        {
            string input = "ABC";

            IFibonacci objIFibo;

            objIFibo = FiboFactory.GetFibonacciType(Common.FiboType.Iterative);
            int output = objIFibo.GetNthFibonacciNumber(input);


            Assert.IsNotNull(output);
            Assert.AreEqual(55, output);
        }

        [TestMethod]
        public void CheckFiboRecursive()
        {
            string input = "11";

            IFibonacci objIFibo;

            objIFibo = FiboFactory.GetFibonacciType(Common.FiboType.Recursive);
            int output = objIFibo.GetNthFibonacciNumber(input);


            Assert.IsNotNull(output);
            Assert.AreEqual(55, output);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void CheckInvalidStringRecursive()
        {
            string input = "ABC";

            IFibonacci objIFibo;

            objIFibo = FiboFactory.GetFibonacciType(Common.FiboType.Recursive);
            int output = objIFibo.GetNthFibonacciNumber(input);


            Assert.IsNotNull(output);
            Assert.AreEqual(55, output);
        }
    }
}
