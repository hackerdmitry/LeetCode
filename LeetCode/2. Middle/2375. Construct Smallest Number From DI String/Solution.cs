using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2375._Construct_Smallest_Number_From_DI_String;

public class Solution
{
    public string SmallestNumber(string pattern)
    {
        var list = new LinkedList<char>();
        list.AddFirst('1');
        var node = list.First;

        for (var i = 0; i < pattern.Length; i++)
            switch (pattern[i])
            {
                case 'I':
                    list.AddLast((char) ('2' + i));
                    node = list.Last;
                    break;
                case 'D':
                    list.AddBefore(node!, (char) ('2' + i));
                    node = node.Previous;
                    break;
            }

        return new string(list.ToArray());
    }
}
