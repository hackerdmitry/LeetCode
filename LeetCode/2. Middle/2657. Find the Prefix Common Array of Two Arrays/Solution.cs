namespace LeetCode._2._Middle._2657._Find_the_Prefix_Common_Array_of_Two_Arrays;

public class Solution
{
    public int[] FindThePrefixCommonArray(int[] a, int[] b)
    {
        var checkmarks = new bool[a.Length];
        var count = 0;
        var c = new int[a.Length];

        for (var i = 0; i < a.Length; i++)
        {
            if (checkmarks[a[i] - 1])
                count++;
            else
                checkmarks[a[i] - 1] = true;

            if (checkmarks[b[i] - 1])
                count++;
            else
                checkmarks[b[i] - 1] = true;

            c[i] = count;
        }

        return c;
    }
}
