using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._2._Middle._3433._Count_Mentions_Per_User;

[TestFixture(TestName = "3433. Count Mentions Per User")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, "[[\"MESSAGE\",\"10\",\"id1 id0\"],[\"OFFLINE\",\"11\",\"0\"],[\"MESSAGE\",\"71\",\"HERE\"]]", "[2,2]")]
    [TestCase(2, "[[\"MESSAGE\",\"10\",\"id1 id0\"],[\"OFFLINE\",\"11\",\"0\"],[\"MESSAGE\",\"12\",\"ALL\"]]", "[2,2]")]
    [TestCase(2, "[[\"OFFLINE\",\"10\",\"0\"],[\"MESSAGE\",\"12\",\"HERE\"]]", "[0,1]")]
    [TestCase(3, "[[\"MESSAGE\",\"2\",\"HERE\"],[\"OFFLINE\",\"2\",\"1\"],[\"OFFLINE\",\"1\",\"0\"],[\"MESSAGE\",\"61\",\"HERE\"]]", "[1,0,2]")]
    public void Test(int input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.CountMentions(input1, input2.ParseStringArray2d());
        var expected = output.ParseIntArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        var inputs = input.Split('\n');
        Test(inputs[0].ParseInt(), inputs[1], output);
    }
}
