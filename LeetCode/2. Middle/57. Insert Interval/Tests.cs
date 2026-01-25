using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._57._Insert_Interval;

[TestFixture(TestName = "57. Insert Interval")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,3],[4,6]]", "[0,5]", "[[0,6]]")]
    [TestCase("[[1,3],[4,6]]", "[2,7]", "[[1,7]]")]
    [TestCase("[[1,2],[3,5],[6,7],[8,10],[12,16]]", "[4,8]", "[[1,2],[3,10],[12,16]]")]
    [TestCase("[[1,3],[6,9]]", "[2,5]", "[[1,5],[6,9]]")]
    [TestCase("[[1,3],[7,9]]", "[4,6]", "[[1,3],[4,6],[7,9]]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.Insert(input1.ParseIntArray2d(), input2.ParseIntArray());
        var expected = output.ParseIntArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
