namespace LeetCode._1._Easy._2210._Count_Hills_and_Valleys_in_an_Array;

public class Solution
{
    public int CountHillValley(int[] nums)
    {
        var result = 0;
        var left = nums[0];
        var right = -1;

        for (var i = 1; i < nums.Length - 1; i++)
        {
            var current = nums[i];
            right = nums[i + 1];

            if (left == current || current == right)
                continue;

            if (left < current && current > right ||
                left > current && current < right)
                result++;
            left = current;
        }

        return result;
    }
}