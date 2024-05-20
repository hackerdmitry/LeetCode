using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1863._Sum_of_All_Subset_XOR_Totals;

[TestFixture(TestName = "1863. Sum of All Subset XOR Totals")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,3]", 6)]
    [TestCase("[5,1,6]", 28)]
    [TestCase("[3,4,5,6,7,8]", 480)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.SubsetXORSum(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
