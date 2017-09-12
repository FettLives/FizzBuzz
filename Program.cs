using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = System.Console.ReadLine().Trim();
            var N = Int32.Parse(line1);

            for (var i = 0; i < N; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    System.Console.WriteLine("FizzBuzz\n");
                }
                else if(i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz\n");
                }
                else if(i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz\n");
                }
                else
            System.Console.WriteLine(i + "\n");
            }

        }
    }
}
