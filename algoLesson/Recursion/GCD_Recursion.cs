using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algoLesson.Recursion
{
    public class GCD_Recursion
    {
        public static int findGCDUsingRecursion(int num1, int num2)
        {
            if (num2 == 0)
            {
                return num1;
            }
            return findGCDUsingRecursion(num2, num1 % num2);
        }
    }
}