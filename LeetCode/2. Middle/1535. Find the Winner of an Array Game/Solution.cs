namespace LeetCode._2._Middle._1535._Find_the_Winner_of_an_Array_Game;

public class Solution
{
    public int GetWinner(int[] arr, int k)
    {
        var maxIndex = 0;
        var startK = 0;

        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[maxIndex] < arr[i])
            {
                maxIndex = i;
                startK = i - 1;
            }

            if (i - startK == k)
                break;
        }

        return arr[maxIndex];
    }
}
