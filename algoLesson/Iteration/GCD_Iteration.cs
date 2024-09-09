using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algoLesson.Iteration
{
    public class GCD_Iteration
    {
        public static int FindGCDUsingIteration(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num1 % num2;
                num1 = num2;
                num2 = temp;
            }
            return num1;
        }
    }
}