using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3074._Apple_Redistribution_into_Boxes;

[TestFixture(TestName = "3074. Apple Redistribution into Boxes")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,3,2]", "[4,3,1,5,2]", 2)]
    [TestCase("[5,5,5]", "[2,4,2,7]", 4)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumBoxes(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
