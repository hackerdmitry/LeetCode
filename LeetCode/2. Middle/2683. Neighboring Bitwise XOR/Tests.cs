using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2683._Neighboring_Bitwise_XOR;

[TestFixture(TestName = "2683. Neighboring Bitwise XOR")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,0]", true)]
    [TestCase("[1,1]", true)]
    [TestCase("[1,0]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.DoesValidArrayExist(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
