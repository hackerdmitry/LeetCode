namespace LeetCode._2._Middle._3025._Find_the_Number_of_Ways_to_Place_People_I;

public class Solution
{
    public int NumberOfPairs(int[][] points)
    {
        var result = 0;

        for (var i = 0; i < points.Length; i++)
            for (var j = 0; j < points.Length; j++)
                if (i != j && IsUpperLeftPointInRectangle(i, j, points) && IsAnyInsideRectangle(i, j, points))
                    result++;

        return result;
    }

    private bool IsUpperLeftPointInRectangle(int upperLeftIndex, int lowerRightIndex, int[][] points)
    {
        var y1 = points[upperLeftIndex][0];
        var x1 = points[upperLeftIndex][1];
        var y2 = points[lowerRightIndex][0];
        var x2 = points[lowerRightIndex][1];

        return y1 >= y2 && x1 <= x2;
    }

    private bool IsAnyInsideRectangle(int upperLeftIndex, int lowerRightIndex, int[][] points)
    {
        var y1 = points[upperLeftIndex][0];
        var x1 = points[upperLeftIndex][1];
        var y2 = points[lowerRightIndex][0];
        var x2 = points[lowerRightIndex][1];

        for (var i = 0; i < points.Length; i++)
            if (upperLeftIndex != i && lowerRightIndex != i &&
                y2 <= points[i][0] && points[i][0] <= y1 &&
                x1 <= points[i][1] && points[i][1] <= x2)
                return false;

        return true;
    }
}
