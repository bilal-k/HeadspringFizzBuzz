using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz.Core.FizzBuzz.Print(1, 100);
            Console.ReadLine();
        }
    }
}
