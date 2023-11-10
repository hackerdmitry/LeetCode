using System.Linq;

namespace LeetCode._1._Easy._905._Sort_Array_By_Parity
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            var orderedNums = new int[nums.Length];

            var evenNumsCount = nums.Count(x => x % 2 == 0);

            var oddIndex = evenNumsCount;
            var evenIndex = 0;

            foreach (var num in nums)
            {
                if (num % 2 == 0)
                    orderedNums[evenIndex++] = num;
                else
                    orderedNums[oddIndex++] = num;
            }

            return orderedNums;
        }
    }
}