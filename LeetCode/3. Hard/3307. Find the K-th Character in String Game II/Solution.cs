namespace LeetCode._3._Hard._3307._Find_the_K_th_Character_in_String_Game_II;

public class Solution
{
    public char KthCharacter(long k, int[] operations)
    {
        var operationsCount = 0;
        var operationsIndex = 0;
        var operationsFactor = 1L;

        while (operationsFactor * 2 < k)
        {
            operationsFactor *= 2;
            operationsIndex++;
        }

        while (k > 1)
        {
            if (operationsFactor < k)
            {
                operationsCount += operations[operationsIndex];
                k -= operationsFactor;
            }

            operationsIndex--;
            operationsFactor /= 2;
        }

        return (char) ('a' + operationsCount % 26);
    }
}