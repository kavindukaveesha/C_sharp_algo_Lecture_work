using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 28827.Recursion
{
    public class Fibonacci
{
    public static long FindFibonacci(int number)
    {
        if (number <= 1)
        {
            return number;
        }
        return FindFibonacci(number - 1) + FindFibonacci(number - 2);
    }
}
}