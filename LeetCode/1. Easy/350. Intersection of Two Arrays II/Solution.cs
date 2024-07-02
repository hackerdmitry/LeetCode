using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._350._Intersection_of_Two_Arrays_II;

public class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        var intersect = new List<int>();

        Array.Sort(nums1);
        Array.Sort(nums2);

        for (int i = 0, j = 0; i < nums1.Length && j < nums2.Length;)
            if (nums1[i] == nums2[j])
            {
                intersect.Add(nums1[i]);
                i++;
                j++;
            }
            else if (nums1[i] < nums2[j])
                i++;
            else
                j++;

        return intersect.ToArray();
    }
}