using NUnit.Framework;

namespace LeetCode._2._Middle._1846._Maximum_Element_After_Decreasing_and_Rearranging;

[TestFixture(TestName = "1846. Maximum Element After Decreasing and Rearranging")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{2,2,1,2,1}, 2)]
    [TestCase(new[]{100,1,1000}, 3)]
    [TestCase(new[]{1,2,3,4,5}, 5)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumElementAfterDecrementingAndRearranging(input);
        Assert.AreEqual(output, actual);
    }
}
