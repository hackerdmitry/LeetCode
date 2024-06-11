using System;
using System.Linq;

namespace LeetCode._1._Easy._1122._Relative_Sort_Array;

public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        var dict = arr2.ToDictionary(x => x, _ => 0);

        for (var i = 0; i < arr1.Length; i++)
            if (dict.ContainsKey(arr1[i]))
            {
                dict[arr1[i]]++;
                arr1[i] = -1;
            }

        Array.Sort(arr1);

        var j = 0;
        var item = dict[arr2[j]];
        for (var i = 0; i < arr1.Length; i++)
        {
            arr1[i] = arr2[j];
            if (--item == 0)
            {
                if (++j == arr2.Length)
                    break;
                item = dict[arr2[j]];
            }
        }

        return arr1;
    }
}