using NUnit.Framework;

namespace LeetCode._1._Easy._455._Assign_Cookies;

[TestFixture(TestName = "455. Assign Cookies")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{1,2,3}, new[]{1,1}, 1)]
    [TestCase(new[]{1,2}, new[]{1,2,3}, 2)]
    [TestCase(new[]{1,2,3}, new[]{3}, 1)]
    public void Test(int[] input1, int[] input2, int output)
    {
        var solution = new Solution();
        var actual = solution.FindContentChildren(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
