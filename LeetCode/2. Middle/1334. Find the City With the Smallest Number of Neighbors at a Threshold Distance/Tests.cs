using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1334._Find_the_City_With_the_Smallest_Number_of_Neighbors_at_a_Threshold_Distance;

[TestFixture(TestName = "1334. Find the City With the Smallest Number of Neighbors at a Threshold Distance")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, "[[0,1,3],[1,2,1],[1,3,4],[2,3,1]]", 4, 3)]
    [TestCase(5, "[[0,1,2],[0,4,8],[1,2,3],[1,4,2],[2,3,1],[3,4,1]]", 2, 0)]
    [TestCase(6, "[[0,1,10],[0,2,1],[2,3,1],[1,3,1],[1,4,1],[4,5,10]]", 20, 5)]
    public void Test(int input1, string input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.FindTheCity(input1, input2.ParseIntArray2d(), input3);
        Assert.AreEqual(output, actual);
    }
}
