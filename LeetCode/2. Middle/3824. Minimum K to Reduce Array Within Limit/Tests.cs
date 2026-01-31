using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3824._Minimum_K_to_Reduce_Array_Within_Limit;

[TestFixture(TestName = "3824. Minimum K to Reduce Array Within Limit")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,7,5]", 3)]
    [TestCase("[1]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumK(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
