using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._2._Middle._128._Longest_Consecutive_Sequence;

[TestFixture(TestName = "128. Longest Consecutive Sequence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[100,4,200,1,3,2]", 4)]
    [TestCase("[0,3,7,2,5,8,4,6,0,1]", 9)]
    [TestCase("[1,0,1,2]", 3)]
    [TestCase("[3,2,1,0]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestConsecutive(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }

    [Timeout(3000)]
    [TestCase("BigTest1")]
    [TestCase("BigTest2")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        Test(input, output.ParseInt());
    }
}