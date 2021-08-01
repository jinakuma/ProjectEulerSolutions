using System;
using Problem_1;
using Problem_2;

namespace ProjectEulerSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenFibonacciNumbers fibonacciNumbers = new EvenFibonacciNumbers();
            
            Console.WriteLine(fibonacciNumbers.SumOfEvenFibonacciNumbers());
            Console.ReadLine();
        }
    }
}
