using System;
using System.Collections.Generic;
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
        public void Empty_DivisorTable_Prints_Number()
        {
            var output = FizzBuzz.Core.FizzBuzz.Get(5, 5, new Dictionary<int, string>());
            Assert.AreEqual("5", output.First());
        }

        [TestMethod]
        public void DivisorTable_Prints_Custom_Description()
        {
            var output = FizzBuzz.Core.FizzBuzz.Get(3, 3, new Dictionary<int, string> {{3, "custom"}});
            Assert.AreEqual("custom", output.First());
        }

        [TestMethod]
        public void DivisorTable_Prints_Description_Based_On_Concatenated_Divisor_Matches()
        {
            var output = FizzBuzz.Core.FizzBuzz.Get(30, 30,
                                                    new Dictionary<int, string> {{10, "custom10"}, {15, "custom15"}});
            Assert.AreEqual("custom10custom15", output.First());
        }

        [TestMethod]
        public void DivisorTable_With_1_Always_Prints_Description()
        {
            var output = FizzBuzz.Core.FizzBuzz.Get(1, 100, new Dictionary<int, string> {{1, "buzzer"}});

            Assert.AreEqual(100, output.Count());
            Assert.IsTrue(output.All(d => (d == "buzzer")));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Null_DivisorTable_Throws_ArgumentNullException()
        {
            FizzBuzz.Core.FizzBuzz.Get(1, 100, null).ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NumbersFrom_Larger_Than_NumbersTo_Throws_ArgumentOutOfRangeException()
        {
            FizzBuzz.Core.FizzBuzz.Get(100, 1).ToList();
        }
    }
}
