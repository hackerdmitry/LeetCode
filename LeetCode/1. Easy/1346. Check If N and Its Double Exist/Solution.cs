using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._1346._Check_If_N_and_Its_Double_Exist;

public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        var hashSet = new HashSet<int>(arr.Length);
        foreach (var elem in arr.OrderByDescending(Math.Abs))
        {
            if (hashSet.Contains(elem * 2))
                return true;
            hashSet.Add(elem);
        }

        return false;
    }
}