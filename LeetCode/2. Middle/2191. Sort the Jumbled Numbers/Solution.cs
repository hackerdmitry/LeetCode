using System.Linq;

namespace LeetCode._2._Middle._2191._Sort_the_Jumbled_Numbers;

public class Solution
{
    public int[] SortJumbled(int[] mapping, int[] nums)
    {
        return nums
            .Select((num, i) => new Node(num, Map(num.ToString(), mapping), i))
            .OrderBy(x => x.MappedNum)
            .ThenBy(x => x.Order)
            .Select(x => x.Original)
            .ToArray();
    }

    private int Map(string number, int[] mapping)
    {
        var mappedNum = 0;
        for (var i = 0; i < number.Length; i++)
            mappedNum = mappedNum * 10 + mapping[number[i] - '0'];
        return mappedNum;
    }

    class Node
    {
        public int Original { get; set; }
        public int MappedNum { get; set; }
        public int Order { get; set; }

        public Node(int original, int mappedNum, int order)
        {
            Original = original;
            MappedNum = mappedNum;
            Order = order;
        }
    }
}
