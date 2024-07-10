using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1598._Crawler_Log_Folder;

[TestFixture(TestName = "1598. Crawler Log Folder")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"d1/\",\"d2/\",\"../\",\"d21/\",\"./\"]", 2)]
    [TestCase("[\"d1/\",\"d2/\",\"./\",\"d3/\",\"../\",\"d31/\"]", 3)]
    [TestCase("[\"d1/\",\"../\",\"../\",\"../\"]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinOperations(input.ParseStringArray());
        Assert.AreEqual(output, actual);
    }
}
