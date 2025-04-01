using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._2._Middle._2140._Solving_Questions_With_Brainpower;

[TestFixture(TestName = "2140. Solving Questions With Brainpower")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[3,2],[4,3],[4,4],[2,5]]", 5)]
    [TestCase("[[21,2],[1,2],[12,5],[7,2],[35,3],[32,2],[80,2],[91,5],[92,3],[27,3],[19,1],[37,3],[85,2],[33,4],[25,1],[91,4],[44,3],[93,3],[65,4],[82,3],[85,5],[81,3],[29,2],[25,1],[74,2],[58,1],[85,1],[84,2],[27,2],[47,5],[48,4],[3,2],[44,3],[60,5],[19,2],[9,4],[29,5],[15,3],[1,3],[60,2],[63,3],[79,3],[19,1],[7,1],[35,1],[55,4],[1,4],[41,1],[58,5]]", 781)]
    [TestCase("[[21,5],[92,3],[74,2],[39,4],[58,2],[5,5],[49,4],[65,3]]", 157)]
    [TestCase("[[1,1],[2,2],[3,3],[4,4],[5,5]]", 7)]
    public void Test(string input, long output)
    {
        var solution = new Solution();
        var actual = solution.MostPoints(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        Test(input, output.ParseLong());
    }
}
