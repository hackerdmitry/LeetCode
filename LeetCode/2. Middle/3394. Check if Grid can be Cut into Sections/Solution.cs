using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3394._Check_if_Grid_can_be_Cut_into_Sections;

public class Solution
{
    public bool CheckValidCuts(int n, int[][] rectangles)
    {
        var startDict1 = new Dictionary<int, int>();
        var endDict1 = new Dictionary<int, int>();
        var startDict2 = new Dictionary<int, int>();
        var endDict2 = new Dictionary<int, int>();

        foreach (var rectangle in rectangles)
        {
            AddPoint(startDict1, rectangle[0]);
            AddPoint(endDict1, rectangle[2]);
            AddPoint(startDict2, rectangle[1]);
            AddPoint(endDict2, rectangle[3]);
        }

        return CountSections(startDict1, endDict1) > 2 || CountSections(startDict2, endDict2) > 2;
    }

    private void AddPoint(Dictionary<int, int> dict, int point)
    {
        if (!dict.TryAdd(point, 1))
            dict[point]++;
    }

    private int CountSections(Dictionary<int, int> startDict, Dictionary<int, int> endDict)
    {
        using var startEnumerator = startDict.OrderBy(x => x.Key).GetEnumerator();
        startEnumerator.MoveNext();
        using var endEnumerator = endDict.OrderBy(x => x.Key).GetEnumerator();
        endEnumerator.MoveNext();

        var countSections = 0;
        var countStarts = startEnumerator.Current.Value;

        bool MoveEnd()
        {
            countStarts -= endEnumerator.Current.Value;
            if (countStarts == 0)
                countSections++;

            return endEnumerator.MoveNext();
        }

        while (startEnumerator.MoveNext())
        {
            while (endEnumerator.Current.Key <= startEnumerator.Current.Key)
            {
                countStarts -= endEnumerator.Current.Value;
                if (countStarts == 0)
                    countSections++;
                endEnumerator.MoveNext();
            }

            countStarts += startEnumerator.Current.Value;
        }

        while (MoveEnd()) ;

        return countSections;
    }
}
