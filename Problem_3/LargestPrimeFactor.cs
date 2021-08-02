using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    public class LargestPrimeFactor
    {
        public long LargestPrimeNumber(long number)
        {
            long k = 2;
            while (k * k <= number)
            {
                if (number % k == 0)
                {
                    number /= k;
                }
                else
                {
                    ++k;
                }
            }

            return number;
        }

       
    }
}
