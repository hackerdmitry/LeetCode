namespace LeetCode._342._Power_of_Four
{
    public class Solution
    {
        public bool IsPowerOfFour(int n)
        {
            while (n > 1)
            {
                if (n % 4 != 0)
                    return false;

                n /= 4;
            }

            return n == 1;
        }
    }
}