namespace LeetCode._1._Easy._796._Rotate_String;

public class Solution
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length)
            return false;

        var length = s.Length;
        for (var i = 0; i < length; i++)
        {
            if (s[0] == goal[i])
            {
                for (var j = 0; j < length; j++)
                    if (s[j] != goal[(i + j) % length])
                        goto next;

                return true;
            }

            next: ;
        }

        return false;
    }
}