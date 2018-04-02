using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzer;

namespace FizzBuzzer
{
    [TestClass]
    public class FizzBuzzerTests
    {
        [TestMethod]
        public void TestsNumber()
        {
            FizzBuzzer objFB = new FizzBuzzer();
            string result = objFB.Generate(25);
            Console.Write(result);
        }
    }
}
