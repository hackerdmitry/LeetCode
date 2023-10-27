namespace LeetCode._5._Longest_Palindromic_Substring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            var start = -1;
            var length = -1;

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = 0; i - j >= 0 && i + j < s.Length; j++)
                {
                    if (s[i - j] == s[i + j])
                    {
                        if (length < j * 2 + 1)
                        {
                            start = i - j;
                            length = j * 2 + 1;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (var i = 0; i < s.Length - 1; i++)
            {
                for (var j = 0; i - j >= 0 && i + j + 1 < s.Length; j++)
                {
                    if (s[i - j] == s[i + j + 1])
                    {
                        if (length < (j + 1) * 2)
                        {
                            start = i - j;
                            length = (j + 1) * 2;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return s.Substring(start, length);
        }
    }
}