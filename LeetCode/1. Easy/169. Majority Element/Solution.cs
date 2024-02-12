namespace LeetCode._1._Easy._169._Majority_Element;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var elem = nums[0];
        var count = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (count == 0)
                elem = nums[i];

            if (elem == nums[i])
                count++;
            else
                count--;
        }

        return elem;
    }
}