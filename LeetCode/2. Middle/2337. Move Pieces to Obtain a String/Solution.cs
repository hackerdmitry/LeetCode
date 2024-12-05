namespace LeetCode._2._Middle._2337._Move_Pieces_to_Obtain_a_String;

public class Solution
{
    public bool CanChange(string start, string target)
    {
        var leftCount = 0;
        var rightCount = 0;

        for (var i = 0; i < start.Length; i++)
        {
            if (target[i] == 'L')
            {
                if (start[i] == 'R' || rightCount > 0)
                    return false;
                leftCount++;
            }

            switch (start[i])
            {
                case 'L':
                    if (leftCount == 0)
                        return false;
                    leftCount--;
                    break;
                case 'R':
                    if (target[i] == 'L' || leftCount > 0)
                        return false;
                    rightCount++;
                    break;
            }

            if (target[i] == 'R')
            {
                if (rightCount == 0)
                    return false;
                rightCount--;
            }
        }

        return leftCount == 0 && rightCount == 0;
    }
}