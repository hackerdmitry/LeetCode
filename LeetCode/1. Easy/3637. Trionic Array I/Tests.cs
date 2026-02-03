using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3637._Trionic_Array_I;

[TestFixture(TestName = "3637. Trionic Array I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,3,5,4,2,6]", true)]
    [TestCase("[2,1,3]", false)]
    [TestCase("[8,9,4,6,1]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsTrionic(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
