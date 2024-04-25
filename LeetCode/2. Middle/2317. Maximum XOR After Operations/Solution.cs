using System.Linq;

namespace LeetCode._2._Middle._2317._Maximum_XOR_After_Operations;

public class Solution
{
    public int MaximumXOR(int[] nums)
    {
        var maxNum = nums.Max();
        if (maxNum == 0)
            return 0;

        var signsCount = 0;
        while (maxNum != 0)
        {
            maxNum /= 2;
            signsCount++;
        }

        var availableOnes = new bool[signsCount];
        for (var i = 0; i < nums.Length; i++)
        {
            var curNum = nums[i];
            for (var j = 0; j < signsCount && curNum != 0; j++, curNum /= 2)
                if (curNum % 2 == 1)
                    availableOnes[j] = true;
        }

        var result = 0;
        for (var i = signsCount - 1; i >= 0; i--)
        {
            if (availableOnes[i])
                result++;
            if (i != 0)
                result <<= 1;
        }

        return result;
    }
}