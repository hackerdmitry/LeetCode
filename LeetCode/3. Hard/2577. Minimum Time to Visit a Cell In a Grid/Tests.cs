using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._3._Hard._2577._Minimum_Time_to_Visit_a_Cell_In_a_Grid;

[TestFixture(TestName = "2577. Minimum Time to Visit a Cell In a Grid")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,1,3,2],[5,1,2,5],[4,3,8,6]]", 7)]
    [TestCase("[[0,2,4],[3,2,1],[1,0,4]]", -1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumTime(input.ParseIntArray2d());
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
