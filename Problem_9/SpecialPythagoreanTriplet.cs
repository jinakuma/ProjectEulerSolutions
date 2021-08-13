using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    public static class SpecialPythagoreanTriplet
    {
        public static int ProductOfPythagoreanTriplet(int sumOfTriplets)
        {
            for (int i = 1; i <= sumOfTriplets / 3; i++)
            {
                for (int j = i + 1; j <= sumOfTriplets / 2; j++)
                {
                    int k = sumOfTriplets - i - j;
                    if (i * i + j * j == k * k)
                    {
                        return i*j*k;
                    }
                }
            }

            return -1;
        }
    }
}
