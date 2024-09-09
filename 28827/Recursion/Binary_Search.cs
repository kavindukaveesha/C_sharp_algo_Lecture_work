using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 28827.Recursion
{
    public class Binary_Search
{
    public static int BinarySearchUsingRecursion(int[] sortedArray, int start, int end, int target)
    {
        if (end < start)
        {
            return -1;
        }
        int middle = (start + end) / 2;
        if (target == sortedArray[middle])
        {
            return middle;
        }
        else if (target < sortedArray[middle])
        {
            return BinarySearchUsingRecursion(sortedArray, start, middle - 1, target);
        }
        else
        {
            return BinarySearchUsingRecursion(sortedArray, middle + 1, end, target);
        }
    }
}
}