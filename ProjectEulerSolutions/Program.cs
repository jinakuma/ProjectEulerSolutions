using System;
using Problem_1;
using Problem_2;
using Problem_3;

namespace ProjectEulerSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            LargestPrimeFactor primeNumber = new LargestPrimeFactor();
            
            
            Console.WriteLine(primeNumber.LargestPrimeNumber(600851475143));
            Console.ReadLine();
        }
    }
}
