using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    public static class SumSquareDifference
    {
        public static void FirstHundredNumbersSumSquareDifference()
        {
            int squareSum = 0;
            int sumSquare = 0;
            for (int i = 1; i <= 100; i++)
            {
                squareSum += i*i;
            }

            for (int i = 1; i <= 100; i++)
            {
                sumSquare += i;
            }

            sumSquare *= sumSquare;
            Console.WriteLine(sumSquare-squareSum);
        }
    }
}
