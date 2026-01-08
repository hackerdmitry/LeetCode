using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._334._Increasing_Triplet_Subsequence;

[TestFixture(TestName = "334. Increasing Triplet Subsequence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,-2,6]", false)]
    [TestCase("[0,4,1,-1,2]", true)]
    [TestCase("[1,2,1,3]", true)]
    [TestCase("[1,5,0,4,1,3]", true)]
    [TestCase("[1,2,3,4,5]", true)]
    [TestCase("[5,4,3,2,1]", false)]
    [TestCase("[2,1,5,0,4,6]", true)]
    [TestCase("[20,100,10,12,5,13]", true)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IncreasingTriplet(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
