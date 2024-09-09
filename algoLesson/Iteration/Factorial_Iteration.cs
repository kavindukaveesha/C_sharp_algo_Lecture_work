using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algoLesson.Iteration
{
    public class Factorial_Iteration
    {
        public static long FindFactorialUsingIteration(int number)
        {
            //set variable for result
            long result = 1;
            for (long i = number; i > 1; i--)
            {
                result = result * i;
            }
            return result;
        }
    }
}