namespace LeetCode._844._Backspace_String_Compare
{
    public class Solution
    {
        public bool BackspaceCompare(string s, string t)
        {
            var i = s.Length - 1;
            var j = t.Length - 1;

            while (i >= 0 || j >= 0)
            {
                var sJump = 1;
                if (i >= 0 && s[i] == '#')
                {
                    i--;

                    while (i >= 0 && s[i] == '#' || sJump > 0)
                    {
                        if (i < 0)
                            break;
                        if (s[i] == '#')
                            sJump++;
                        else
                            sJump--;
                        i--;
                    }
                }

                var tJump = 1;
                if (j >= 0 && t[j] == '#')
                {
                    j--;

                    while (j >= 0 && t[j] == '#' || tJump > 0)
                    {
                        if (j < 0)
                            break;
                        if (t[j] == '#')
                            tJump++;
                        else
                            tJump--;
                        j--;
                    }
                }

                if (i < 0 && j < 0)
                    break;

                if (i >= 0 && j >= 0 && s[i] != t[j] ||
                    i >= 0 && j < 0 && s[i] != '#' ||
                    j >= 0 && i < 0 && t[j] != '#')
                    return false;

                i--;
                j--;
            }

            return true;
        }
    }
}