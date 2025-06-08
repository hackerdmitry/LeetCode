using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._386._Lexicographical_Numbers;

public class Solution
{
    public IList<int> LexicalOrder(int n)
    {
        return CreateLexicalOrderEnumerable(1, n).ToArray();
    }

    private IEnumerable<int> CreateLexicalOrderEnumerable(int start, int max)
    {
        var end = start + (10 - start % 10);
        while (start < end && start <= max)
        {
            yield return start;
            if (start * 10 <= max)
                foreach (var n in CreateLexicalOrderEnumerable(start * 10, max))
                    yield return n;
            start++;
        }
    }
}