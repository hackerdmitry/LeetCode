using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._338._Counting_Bits;

[TestFixture(TestName = "338. Counting Bits")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, "[0,1,1]")]
    [TestCase(5, "[0,1,1,2,1,2]")]
    public void Test(int input, string output)
    {
        var solution = new Solution();
        var actual = solution.CountBits(input);
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
