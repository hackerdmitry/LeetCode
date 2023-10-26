namespace LeetCode._779._K_th_Symbol_in_Grammar
{
    public class Solution
    {
        public int KthGrammar(int n, int k)
        {
            var inverted = false;

            var len = 1;
            for (var i = 1; i < n; i++)
                len *= 2;

            for (var i = 1; i < n; i++)
            {
                if (k > len / 2)
                {
                    inverted = !inverted;
                    k -= len / 2;
                }

                len /= 2;
            }

            return k == 1 ^ inverted ? 0 : 1;
        }
    }
}