using System.Linq;

namespace LeetCode._2._Middle._1524._Number_of_Sub_arrays_With_Odd_Sum;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int NumOfSubarrays(int[] arr)
    {
        var sign = new bool[arr.Length];

        sign[^1] = arr[^1] % 2 == 1;
        for (var i = arr.Length - 2; i >= 0; i--)
            sign[i] = (arr[i] % 2 == 1) ^ sign[i + 1];

        var isOdd = true;
        var oddCount = sign.Count(x => x);

        var sum = 0;
        for (var i = 0; i < sign.Length; i++)
        {
            sum = (sum + oddCount) % modulo;
            if (!isOdd ^ sign[i])
            {
                oddCount = sign.Length - i - oddCount;
                isOdd = !isOdd;
            }
        }

        return sum;
    }
}
