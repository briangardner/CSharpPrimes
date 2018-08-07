using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var validator = new PrimeNumberValidator();
            List<int> primes = new List<int>();
            int number = 2;
            do
            {
                if (validator.IsPrime(number))
                {
                    primes.Add(number);
                }

                number++;
            } while (primes.Count < 100);

            foreach (var prime in primes)
            {
                Console.WriteLine(prime);
            }

            Console.ReadKey();
        }

        private static bool ShouldContinue()
        {
            do
            {
                Console.Write("Continue y/n:");
                var input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (input != 'y' && input != 'n')
                {
                    continue;
                }

                return input == 'y';
            } while (true);
        }
    }
}
