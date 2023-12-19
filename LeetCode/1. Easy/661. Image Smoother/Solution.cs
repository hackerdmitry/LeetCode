using System;

namespace LeetCode._1._Easy._661._Image_Smoother;

public class Solution
{
    public int[][] ImageSmoother(int[][] img)
    {
        var result = new int[img.Length][];

        for (var i = 0; i < img.Length; i++)
        {
            result[i] = new int[img[i].Length];

            for (var j = 0; j < img[i].Length; j++)
            {
                var count = 0;
                for (var x = Math.Max(i - 1, 0); x < Math.Min(i + 2, img.Length); x++)
                {
                    for (var y = Math.Max(j - 1, 0); y < Math.Min(j + 2, img[i].Length); y++)
                    {
                        count++;
                        result[i][j] += img[x][y];
                    }
                }

                result[i][j] /= count;
            }
        }

        return result;
    }
}
