using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Problem_2
{
    public class EvenFibonacciNumbers
    {
        public int SumOfEvenFibonacciNumbers()
        {
            int sum = 2;
            List<int> fibonacciNumbersList = new List<int>{1,2};
            int length = fibonacciNumbersList.Count();
            while (fibonacciNumbersList[length - 1] < 4000000)
            {
                int lastNumber = fibonacciNumbersList[length - 1] + fibonacciNumbersList[length - 2];
                if (lastNumber%2==0)
                {
                    sum += lastNumber;
                }
                fibonacciNumbersList.Add(lastNumber);
                length = fibonacciNumbersList.Count();
            }
            
            return sum;
        }
    }
}
