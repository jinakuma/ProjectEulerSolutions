using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_10
{
    public static class SummationOfPrimes
    {
        public static long GeneratePrimesNaive(int n)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int nextPrime = 3;
            while (primes[^1] < n)
            {
                int sqrt = (int)Math.Sqrt(nextPrime);
                bool isPrime = true;
                for (int i = 0; (int)primes[i] <= sqrt; i++)
                {
                    if (nextPrime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextPrime);
                }
                nextPrime += 2;
            }

            long sum =0;
            foreach (var prime in primes)
            {
                //Console.WriteLine(prime);
                sum += Convert.ToInt64(prime);
            }

            sum -= primes[^1];

            return sum;
        }
    }
}
