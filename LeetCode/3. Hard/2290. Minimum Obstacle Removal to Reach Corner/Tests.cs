using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._3._Hard._2290._Minimum_Obstacle_Removal_to_Reach_Corner;

[TestFixture(TestName = "2290. Minimum Obstacle Removal to Reach Corner")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,1,0,0,0],[0,1,0,1,0],[0,0,0,1,0]]", 0)]
    [TestCase("[[0,1,1],[1,1,0],[1,1,0]]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumObstacles(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        Test(input, output.ParseInt());
    }
}
