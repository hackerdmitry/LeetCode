using System.Linq;

namespace LeetCode._1._Easy._645._Set_Mismatch;

public class Solution
{
    public int[] FindErrorNums(int[] nums)
    {
        var duplicated = -1;

        var counter = 0;
        while (counter < nums.Length)
        {
            if (nums[counter] < 0)
            {
                counter++;
                continue;
            }

            if (nums[counter] == counter + 1)
            {
                nums[counter] = -counter - 1;
                counter++;
                continue;
            }

            var index = nums[counter] - 1;
            while (index != counter)
            {
                if (nums[index] == 0)
                {
                    nums[index] = -index - 1;
                    break;
                }

                if (nums[index] < 0)
                {
                    duplicated = index + 1;
                    break;
                }

                var temp = index;
                index = nums[index] - 1;
                nums[temp] = -temp - 1;
            }

            if (index == counter)
                nums[index] = -index - 1;
            else
                nums[counter] = 0;
            counter++;
        }

        return new[] { duplicated, Enumerable.Range(0, nums.Length).First(x => nums[x] == 0) + 1 };
    }
}
