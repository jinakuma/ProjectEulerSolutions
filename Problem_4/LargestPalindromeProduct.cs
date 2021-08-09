using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    public class LargestPalindromeProduct
    {
        

        public static void Run()
        {
            int answer = 0;
            int maxPalindrome = 0;

            int i = 0;
            int j = 0;

            for (i = 999; i > 99; i--)
            {
                for (j = 999; j >= 99; j--)
                {
                    int product = i * j;

                    if (IsPalindrome(product))
                    {
                        maxPalindrome = product;

                        

                        break; // inner for
                    }
                }

                if (maxPalindrome>answer)
                {
                    answer = maxPalindrome;
                }
                


            }
            Console.WriteLine(answer);

            Console.ReadLine();
        }

        static bool IsPalindrome(int number)
        {
            int numberAux = number;
            int reversedNumber = 0;

            while (numberAux > 0)
            {
                int rightDigit = numberAux % 10;
                reversedNumber = reversedNumber * 10 + rightDigit;
                numberAux = numberAux / 10;
            }

            return number == reversedNumber;
        }
    }
}
