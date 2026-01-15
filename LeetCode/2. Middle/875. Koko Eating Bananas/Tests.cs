using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._875._Koko_Eating_Bananas;

[TestFixture(TestName = "875. Koko Eating Bananas")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,6,7,11]", 8, 4)]
    [TestCase("[30,11,23,4,20]", 5, 30)]
    [TestCase("[30,11,23,4,20]", 6, 23)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinEatingSpeed(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
