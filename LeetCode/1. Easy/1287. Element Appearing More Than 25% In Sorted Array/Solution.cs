using System;

namespace LeetCode._1._Easy._1287._Element_Appearing_More_Than_25__In_Sorted_Array;

public class Solution
{
    public int FindSpecialInteger(int[] arr)
    {
        var moreThan25 = Math.Ceiling(arr.Length * 0.25);
        if (arr.Length % 4 == 0)
            moreThan25++;

        var lastSameIndex = 0;
        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[lastSameIndex])
                lastSameIndex = i;

            if (i - lastSameIndex + 1 >= moreThan25)
                break;
        }

        return arr[lastSameIndex];
    }
}
