namespace LeetCode._2._Middle._3335._Total_Characters_in_String_After_Transformations_I;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int LengthAfterTransformations(string s, int t)
    {
        var arr1 = new int[26];
        var arr2 = new int[26];
        var isCurrArr1 = true;

        foreach (var c in s)
            arr1[c - 'a']++;

        void AddToDestination(int count)
        {
            if (isCurrArr1)
                this.AddToDestination(arr1, arr2, count);
            else
                this.AddToDestination(arr2, arr1, count);
            isCurrArr1 = !isCurrArr1;
        }

        while (t >= 25)
        {
            AddToDestination(25);
            t -= 25;
        }

        if (t > 0)
            AddToDestination(t);

        if (!isCurrArr1)
            arr1 = arr2;

        var result = 0;
        foreach (var value in arr1)
            result = (result + value) % modulo;
        return result;
    }

    private void AddToDestination(int[] source, int[] destination, int count)
    {
        for (var i = 0; i < source.Length; i++)
        {
            if (i + count < source.Length)
                AddToElementDestination(destination, i + count, source[i]);
            else
            {
                AddToElementDestination(destination, (i + count) % source.Length, source[i]);
                AddToElementDestination(destination, (i + count + 1) % source.Length, source[i]);
            }

            source[i] = 0;
        }
    }

    private void AddToElementDestination(int[] destination, int index, int value) =>
        destination[index] = (destination[index] + value) % modulo;
}