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
            foreach (string line in Get(numbersFrom, numbersTo))
                Console.WriteLine(line);
        }

        public static IEnumerable<string> Get(int numbersFrom, int numbersTo)
        {
            if (numbersFrom > numbersTo)
                throw new ArgumentOutOfRangeException("numbersFrom should be less than or equal to numbersTo.");

            for (int i = numbersFrom; i <= numbersTo; i++)
            {
                if (i % 15 == 0)
                    yield return "fizzbuzz";
                else if (i % 3 == 0)
                    yield return "fizz";
                else if (i % 5 == 0)
                    yield return "buzz";
                else
                    yield return i.ToString();
            }
        }
    }
}
