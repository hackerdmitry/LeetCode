using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3477._Fruits_Into_Baskets_II;

[TestFixture(TestName = "3477. Fruits Into Baskets II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,2,5]", "[3,5,4]", 1)]
    [TestCase("[3,6,1]", "[6,4,7]", 0)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.NumOfUnplacedFruits(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
