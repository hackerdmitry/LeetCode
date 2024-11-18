using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._1652._Defuse_the_Bomb;

public class Solution
{
    public int[] Decrypt(int[] code, int k) =>
        k == 0
            ? Enumerable.Repeat(0, code.Length).ToArray()
            : GetDecryptedCode(code, k).ToArray();

    private IEnumerable<int> GetDecryptedCode(int[] code, int k)
    {
        var sum = Enumerable.Range(k > 0 ? 1 : k, Math.Abs(k)).Select(x => code[Normalize(x, code.Length)]).Sum();
        yield return sum;

        for (var i = 1; i < code.Length; i++)
        {
            sum += k > 0
                ? code[Normalize(i + k, code.Length)] - code[i]
                : code[i - 1] - code[Normalize(i + k - 1, code.Length)];
            yield return sum;
        }
    }

    private int Normalize(int i, int n) =>
        i < 0
            ? i + n
            : i >= n
                ? i - n
                : i;
}
