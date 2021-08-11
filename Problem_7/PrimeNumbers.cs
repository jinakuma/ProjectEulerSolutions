using System;
using System.Collections.Generic;

namespace Problem_7
{
    public static class PrimeNumbers
    {
        public static void PrimeNumber10001st()
        {
            
            int upperLimit = 10001;
            int counter = 1;

            bool isPrime;
            int j;
            List<int> primes = new List<int>();

            primes.Add(2);

            while (primes.Count < upperLimit)
            {
                counter += 2;
                j = 0;
                isPrime = true;
                while (primes[j] * primes[j] <= counter)
                {
                    if (counter % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }

                    j++;
                }

                if (isPrime)
                {
                    primes.Add(counter);
                }
            }

            Console.WriteLine(counter);
        }
    }
}
