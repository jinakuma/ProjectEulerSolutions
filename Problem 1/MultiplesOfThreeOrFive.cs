using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    public class MultiplesOfThreeOrFive
    {
        private int sum = 0;

        public int MultipleOfThreeOrFive(int value)
        {
            for (int i=0; i <= value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

    }
}
