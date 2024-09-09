using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algoLesson.Recursion
{
    public class Factorial
    {
        public static long FindFactorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            return number * FindFactorial(number - 1);
        }
    }
}