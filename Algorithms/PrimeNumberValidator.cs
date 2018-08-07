using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class PrimeNumberValidator
    {

        public bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            var ceiling = Math.Sqrt(number);
            for (int i = 3; i <= ceiling; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
