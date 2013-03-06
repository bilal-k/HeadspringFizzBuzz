using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Core;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Multiple_Of_3_Prints_Fizz()
        {
            var output = FizzBuzz.Core.FizzBuzz.Get(6, 6);
            Assert.AreEqual("fizz", output.First());
        }

        [TestMethod]
        public void Multiple_Of_5_Prints_Buzz()
        {
            var output = FizzBuzz.Core.FizzBuzz.Get(10, 10);
            Assert.AreEqual("buzz", output.First());
        }

        [TestMethod]
        public void Multiple_Of_Both_3_And_5_Prints_FizzBuzz()
        {
            var output = FizzBuzz.Core.FizzBuzz.Get(30, 30);
            Assert.AreEqual("fizzbuzz", output.First());
        }

        [TestMethod]
        public void Multiple_Of_Neither_3_Or_5_Prints_Number()
        {
            var output = FizzBuzz.Core.FizzBuzz.Get(4, 4);
            Assert.AreEqual("4", output.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NumbersFrom_Larger_Than_NumbersTo_Throws_ArgumentOutOfRangeException()
        {
            FizzBuzz.Core.FizzBuzz.Get(100, 1).ToList();
        }
    }
}
