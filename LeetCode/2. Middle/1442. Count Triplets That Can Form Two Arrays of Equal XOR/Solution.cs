namespace LeetCode._2._Middle._1442._Count_Triplets_That_Can_Form_Two_Arrays_of_Equal_XOR;

public class Solution
{
    public int CountTriplets(int[] arr)
    {
        var result = 0;

        for (var i = 0; i < arr.Length - 1; i++)
        {
            var number = arr[i];
            for (var j = i + 1; j < arr.Length; j++)
            {
                number ^= arr[j];
                if (number == 0)
                    result += j - i;
            }
        }

        return result;
    }
}