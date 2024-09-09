using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace algoLesson.Iteration
{
    public class Binary_Search_Iteration
    {
        public static int BinarySearchUsingIteration(int target, int[] sortedArray)
        {
            int start = 0;
            int end = sortedArray.Length - 1;
            while (start <= end)
            {
                int middle = start + (end - start) / 2;
                if (target == sortedArray[middle])
                {
                    return middle;
                }
                else if (target < sortedArray[middle])
                {
                    end = middle - 1;
                }
                else
                {
                    start = middle + 1;
                }
            }
            return -1;

        }
    }
}