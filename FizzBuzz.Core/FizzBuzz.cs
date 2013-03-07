using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Core
{
    public static class FizzBuzz
    {
        public static void Print(int numbersFrom, int numbersTo)
        {
            Print(numbersFrom, numbersTo, new Dictionary<int, string>
                                              {
                                                  { 3, "fizz" },
                                                  { 5, "buzz" }
                                              });
        }

        public static void Print(int numbersFrom, int numbersTo, Dictionary<int, string> divisorTable)
        {
            foreach (string line in Get(numbersFrom, numbersTo, divisorTable))
                Console.WriteLine(line);
        }

        public static IEnumerable<string> Get(int numbersFrom, int numbersTo)
        {
            return Get(numbersFrom, numbersTo, new Dictionary<int, string>
                                                {
                                                  { 3, "fizz" },
                                                  { 5, "buzz" }
                                                });
        }

        public static IEnumerable<string> Get(int numbersFrom, int numbersTo, Dictionary<int, string> divisorTable)
        {
            if (numbersFrom > numbersTo)
                throw new ArgumentOutOfRangeException("numbersFrom", "numbersFrom should be less than or equal to numbersTo");
            if (divisorTable == null)
                throw new ArgumentNullException("divisorTable");

            var divisors = divisorTable.Keys.OrderBy(d => d);

            for (int i = numbersFrom; i <= numbersTo; i++)
            {
                string description = "";

                foreach (int divisor in divisors)
                {
                    if (i % divisor == 0)
                    {
                        description += divisorTable[divisor];
                    }
                }

                if (!String.IsNullOrEmpty(description))
                    yield return description;
                else
                    yield return i.ToString();
            }
        }
    }
}
