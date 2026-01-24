using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._219._Contains_Duplicate_II;

[TestFixture(TestName = "219. Contains Duplicate II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,1]", 3, true)]
    [TestCase("[1,0,1,1]", 1, true)]
    [TestCase("[1,2,3,1,2,3]", 2, false)]
    public void Test(string input1, int input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.ContainsNearbyDuplicate(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}