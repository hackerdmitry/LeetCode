using System.Linq;

namespace LeetCode._1220._Count_Vowels_Permutation
{
    public class Solution
    {
        private const int modulo = 1_000_000_007;

        public int CountVowelPermutation(int n)
        {
            var vowels = new int[n, 5];
            for (var i = 0; i < 5; i++)
                vowels[0, i] = 1;

            for (var i = 1; i < n; i++)
            {
                vowels[i, 0] = ((vowels[i - 1, 1] + vowels[i - 1, 2]) % modulo + vowels[i - 1, 4]) % modulo;
                vowels[i, 1] = (vowels[i - 1, 0] + vowels[i - 1, 2]) % modulo;
                vowels[i, 2] = (vowels[i - 1, 1] + vowels[i - 1, 3]) % modulo;
                vowels[i, 3] = vowels[i - 1, 2];
                vowels[i, 4] = (vowels[i - 1, 2] + vowels[i - 1, 3]) % modulo;
            }

            return (int)(Enumerable.Range(0, 5).Sum(i => (long)vowels[n - 1, i]) % modulo);
        }
    }
}
