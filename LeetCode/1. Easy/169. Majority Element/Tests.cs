using NUnit.Framework;

namespace LeetCode._1._Easy._169._Majority_Element;

[TestFixture(TestName = "169. Majority Element")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{3,2,3}, 3)]
    [TestCase(new[]{2,2,1,1,1,2,2}, 2)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MajorityElement(input);
        Assert.AreEqual(output, actual);
    }
}
