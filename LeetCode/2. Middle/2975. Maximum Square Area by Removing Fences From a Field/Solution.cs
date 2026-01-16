using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2975._Maximum_Square_Area_by_Removing_Fences_From_a_Field;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int MaximizeSquareArea(int m, int n, int[] hFences, int[] vFences)
    {
        var hSections = ToSections(m, hFences);
        var vSections = ToSections(n, vFences);

        var hSides = GetPossibleSides(hSections);
        var vSides = GetPossibleSides(vSections);

        var maxSide = 0;
        foreach (var h in hSides)
            if (vSides.Contains(h) && h > maxSide)
                maxSide = h;

        return maxSide == 0 ? -1 : (int) ((long) maxSide * maxSide % modulo);
    }

    private int[] ToSections(int side, int[] fences)
    {
        Array.Sort(fences);

        var sections = new int[fences.Length + 1];
        var prev = 1;
        for (var i = 0; i < sections.Length; i++)
            if (i == fences.Length)

                sections[i] = side - prev;
            else
            {
                sections[i] = fences[i] - prev;
                prev = fences[i];
            }

        return sections;
    }

    private HashSet<int> GetPossibleSides(int[] sections)
    {
        var possibleSides = new HashSet<int>(sections.Length * (sections.Length - 1) / 2);
        for (var i = 0; i < sections.Length; i++)
        {
            var sum = sections[i];
            possibleSides.Add(sum);
            for (var j = i + 1; j < sections.Length; j++)
            {
                sum += sections[j];
                possibleSides.Add(sum);
            }
        }

        return possibleSides;
    }
}