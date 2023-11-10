namespace LeetCode._2433._Find_The_Original_Array_of_Prefix_Xor
{
    public class Solution
    {
        public int[] FindArray(int[] pref)
        {
            for (var i = pref.Length - 1; i >= 1; i--)
                pref[i] ^= pref[i - 1];

            return pref;
        }
    }
}