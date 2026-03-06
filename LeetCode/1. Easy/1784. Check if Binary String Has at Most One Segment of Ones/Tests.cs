using NUnit.Framework;

namespace LeetCode._1._Easy._1784._Check_if_Binary_String_Has_at_Most_One_Segment_of_Ones;

[TestFixture(TestName = "1784. Check if Binary String Has at Most One Segment of Ones")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("1001", false)]
    [TestCase("110", true)]
    [TestCase("111", true)]
    [TestCase("1", true)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.CheckOnesSegment(input);
        Assert.AreEqual(output, actual);
    }
}
