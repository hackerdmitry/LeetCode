namespace LeetCode._2._Middle._162._Find_Peak_Element;

public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        if (nums.Length == 1)
            return 0;

        var leftIsLower = true;
        var rightIsLower = nums[0] > nums[1];

        var index = 0;
        while (!leftIsLower || !rightIsLower)
        {
            leftIsLower = nums[index] < nums[++index];
            if (index < nums.Length - 1)
                rightIsLower = nums[index] > nums[index + 1];
            else
                return index;
        }

        return index;
    }
}
