namespace LeetCode._2._Middle._75._Sort_Colors;

public class Solution
{
    public void SortColors(int[] nums)
    {
        var colors = new int[3];
        foreach (var num in nums)
            colors[num]++;

        var i = 0;
        for (var j = 0; j < colors.Length; j++)
            while (colors[j]-- != 0)
                nums[i++] = j;
    }
}