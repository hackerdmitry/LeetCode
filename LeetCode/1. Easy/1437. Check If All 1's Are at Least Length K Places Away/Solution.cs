namespace LeetCode._1._Easy._1437._Check_If_All_1_s_Are_at_Least_Length_K_Places_Away;

public class Solution
{
    public bool KLengthApart(int[] nums, int k)
    {
        var prevOneIndex = -1;
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] == 1)
                if (prevOneIndex == -1 || i - prevOneIndex > k)
                    prevOneIndex = i;
                else
                    return false;
        return true;
    }
}
