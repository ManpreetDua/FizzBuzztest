using System;
using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzertest.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        /* A single test method to test numbers divided by 3,5 and 3&5 and not 3&5.*/
        [Test]
        public void GenerateTest()
        {
            FizzBuzzer objFB = new FizzBuzzer();
            int[] inputvalue = { 9, 40, 30, 10004 };
            for (int i = 0; i < inputvalue.Length; i++)
            {
                string[] expected = { "Fizz", "Buzz", "FizzBuzz", "10004" };
                string actual = objFB.Generate(inputvalue[i]);
                Assert.AreEqual(expected[i], actual);
            }
        }
        /* Another way to test same thing by dividing it into number of test methods*/
        [Test]
        public void GenerateTestdivideby3()
        {
            FizzBuzzer objFB = new FizzBuzzer();
            int inputvalue = 6;
            string expected = "Fizz";
            string actual = objFB.Generate(inputvalue);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void GenerateTestdivideby5()
        {
            FizzBuzzer objFB = new FizzBuzzer();
            int inputvalue = 10;
            string expected = "Buzz";
            string actual = objFB.Generate(inputvalue);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void GenerateTestdivideby3and5()
        {
            FizzBuzzer objFB = new FizzBuzzer();
            int inputvalue = 15;
            string expected = "FizzBuzz";
            string actual = objFB.Generate(inputvalue);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void GenerateTestnotdivideby3or5()
        {
            FizzBuzzer objFB = new FizzBuzzer();
            int inputvalue = 1001;
            string expected = "1001";
            string actual = objFB.Generate(inputvalue);
            Assert.AreEqual(expected, actual);

        }
    }
}
