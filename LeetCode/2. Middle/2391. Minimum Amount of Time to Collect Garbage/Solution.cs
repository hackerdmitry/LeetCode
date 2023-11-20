namespace LeetCode._2._Middle._2391._Minimum_Amount_of_Time_to_Collect_Garbage;

public class Solution
{
    public int GarbageCollection(string[] garbage, int[] travel)
    {
        var p = 0;
        var g = 0;
        var m = 0;

        var pSum = 0;
        var gSum = 0;
        var mSum = 0;

        var sum = 0;

        for (var i = 0; i < garbage.Length; i++)
        {
            var pFinded = false;
            var gFinded = false;
            var mFinded = false;

            for (var j = 0; j < garbage[i].Length; j++)
            {
                switch (garbage[i][j])
                {
                    case 'P':
                        if (!pFinded)
                        {
                            pFinded = true;
                            pSum = sum;
                        }
                        p++;
                        break;
                    case 'G':
                        if (!gFinded)
                        {
                            gFinded = true;
                            gSum = sum;
                        }
                        g++;
                        break;
                    case 'M':
                        if (!mFinded)
                        {
                            mFinded = true;
                            mSum = sum;
                        }
                        m++;
                        break;
                }
            }

            if (i < travel.Length)
                sum += travel[i];
        }

        return pSum + gSum + mSum + p + g + m;
    }
}
