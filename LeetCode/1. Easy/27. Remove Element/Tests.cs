using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._27._Remove_Element;

[TestFixture(TestName = "27. Remove Element")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,2,2,3]", 3, 2)]
    [TestCase("[0,1,2,2,3,0,4,2]", 2, 5)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.RemoveElement(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
