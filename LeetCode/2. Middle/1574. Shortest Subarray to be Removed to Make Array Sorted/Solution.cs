using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1574._Shortest_Subarray_to_be_Removed_to_Make_Array_Sorted;

public class Solution
{
    public int FindLengthOfShortestSubarray(int[] arr) =>
        new[]
        {
            StartIncreasingArray(arr),
            MiddleIncreasingArray(arr),
            EndIncreasingArray(arr),
        }.Min();

    private int StartIncreasingArray(int[] arr)
    {
        for (var i = 1; i < arr.Length; i++)
            if (arr[i] < arr[i - 1])
                return arr.Length - i;

        return 0;
    }

    private int MiddleIncreasingArray(int[] arr)
    {
        if (arr[0] > arr[^1])
            return arr.Length - 1;

        var left = 0;
        var right = arr.Length - 1;

        var middleVariants = new List<int>();

        while (left >= 0 && left < right)
            if (arr[left] <= arr[left + 1] &&
                arr[left + 1] <= arr[right])
                left++;
            else if (arr[left] <= arr[right - 1] &&
                     arr[right - 1] <= arr[right])
                right--;
            else
            {
                middleVariants.Add(right - left - 1);
                if (arr[right - 1] > arr[right])
                    break;
                while (left >= 0 && arr[left] > arr[right - 1])
                    left--;
                right--;
            }

        return middleVariants.Count == 0 ? 0 : middleVariants.Min();
    }

    private int EndIncreasingArray(int[] arr)
    {
        for (var i = arr.Length - 2; i >= 0; i--)
            if (arr[i] > arr[i + 1])
                return i + 1;

        return 0;
    }
}
