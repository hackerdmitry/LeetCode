using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._386._Lexicographical_Numbers;

[TestFixture(TestName = "386. Lexicographical Numbers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(13, "[1,10,11,12,13,2,3,4,5,6,7,8,9]")]
    [TestCase(2, "[1,2]")]
    public void Test(int input, string output)
    {
        var solution = new Solution();
        var actual = solution.LexicalOrder(input);
        var expected = output.ParseIntArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}