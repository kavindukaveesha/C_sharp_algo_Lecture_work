using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 28827.Iteration
{
    public class Fibonacci_Iteration
{
    public static long FindFibonacciUsingIteration(int number)
    {
        if (number <= 1)
        {
            return number;
        }
        int currentFib = 1;
        int previousFib = 1;

        for (int i = 2; i < number; i++)

        {
            int temp = currentFib;
            currentFib = currentFib + previousFib;
            previousFib = temp;
        }
        return currentFib;
    }
}
}