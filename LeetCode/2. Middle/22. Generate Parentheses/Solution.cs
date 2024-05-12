using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._22._Generate_Parentheses;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        n--;
        var hashSet = new HashSet<string> {"()"};
        while (n-- != 0)
        {
            var array = hashSet.ToArray();
            hashSet.Clear();
            foreach (var parentheses in array)
                for (var i = 0; i < parentheses.Length; i++)
                    hashSet.Add(parentheses.Insert(i, "()"));
        }

        return hashSet.ToArray();
    }
}