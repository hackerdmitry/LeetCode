using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2779._Maximum_Beauty_of_an_Array_After_Applying_Operation;

[TestFixture(TestName = "2779. Maximum Beauty of an Array After Applying Operation")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1]", 0, 2)]
    [TestCase("[100000]", 0, 1)]
    [TestCase("[4,6,1,2]", 2, 3)]
    [TestCase("[1,1,1,1]", 10, 4)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumBeauty(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
