using NUnit.Framework;

namespace LeetCode._2._Middle._1814._Count_Nice_Pairs_in_an_Array;

[TestFixture(TestName = "1814. Count Nice Pairs in an Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{42,11,1,97}, 2)]
    [TestCase(new[]{13,10,35,24,76}, 4)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountNicePairs(input);
        Assert.AreEqual(output, actual);
    }
}
