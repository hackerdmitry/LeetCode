using NUnit.Framework;

namespace LeetCode._1._Easy._268._Missing_Number;

[TestFixture(TestName = "268. Missing Number")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{3,0,1}, 2)]
    [TestCase(new[]{0,1}, 2)]
    [TestCase(new[]{9,6,4,2,3,5,7,0,1}, 8)]
    [TestCase(new[]{2,0,1}, 3)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MissingNumber(input);
        Assert.AreEqual(output, actual);
    }
}
