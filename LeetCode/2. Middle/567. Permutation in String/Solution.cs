using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._567._Permutation_in_String;

public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        var letters = s1.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        var permutation = new Queue<char>();

        for (var i = 0; i < s2.Length; i++)
        {
            var curLetter = s2[i];
            if (letters.ContainsKey(curLetter))
            {
                 if (letters[curLetter] == 0)
                     ClearPermutation(letters, permutation, curLetter);
                 permutation.Enqueue(curLetter);
                 letters[curLetter]--;
            }
            else
                ClearPermutation(letters, permutation);

            if (permutation.Count == s1.Length)
                return true;
        }

        return false;
    }

    private void ClearPermutation(Dictionary<char, int> letters, Queue<char> permutation, char? stopLetter = null)
    {
        while (permutation.Count > 0)
        {
            var letter = permutation.Dequeue();
            letters[letter]++;
            if (letter == stopLetter)
                break;
        }
    }
}
