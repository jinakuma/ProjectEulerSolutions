using System;
using Problem_10;
namespace ProjectEulerSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SummationOfPrimes.GeneratePrimesNaive(2000000));
            Console.ReadLine();
        }
    }
}
