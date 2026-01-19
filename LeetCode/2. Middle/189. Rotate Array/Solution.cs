namespace LeetCode._2._Middle._189._Rotate_Array;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        if (k == 0)
            return;

        var lcm = LCM(nums.Length, k);
        for (var i = 0; i < lcm; i++)
            for (var j = (i + k) % nums.Length; j != i; j = (j + k) % nums.Length)
                (nums[j], nums[i]) = (nums[i], nums[j]);
    }

    private int LCM(int a, int b)
    {
        while (a != b)
            if (a > b)
                a -= b;
            else
                b -= a;
        return a;
    }
}