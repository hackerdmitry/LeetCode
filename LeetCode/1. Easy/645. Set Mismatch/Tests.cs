using NUnit.Framework;

namespace LeetCode._1._Easy._645._Set_Mismatch;

[TestFixture(TestName = "645. Set Mismatch")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{1,2,2,4}, new[]{2,3})]
    [TestCase(new[]{1,1}, new[]{1,2})]
    [TestCase(new[]{5,3,4,5,1}, new[]{5,2})]
    [TestCase(new[]{8,7,3,5,3,6,1,4}, new[]{3,2})]
    public void Test(int[] input, int[] output)
    {
        var solution = new Solution();
        var actual = solution.FindErrorNums(input);
        Assert.AreEqual(output, actual);
    }
}
