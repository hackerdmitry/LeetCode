using NUnit.Framework;

namespace LeetCode._2._Middle._1318._Minimum_Flips_to_Make_a_OR_b_Equal_to_c;

[TestFixture(TestName = "1318. Minimum Flips to Make a OR b Equal to c")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, 6, 5, 3)]
    [TestCase(4, 2, 7, 1)]
    [TestCase(1, 2, 3, 0)]
    public void Test(int input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MinFlips(input1, input2, input3);
        Assert.AreEqual(output, actual);
    }
}
