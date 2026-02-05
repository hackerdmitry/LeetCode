using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3379._Transformed_Array;

[TestFixture(TestName = "3379. Transformed Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,-2,1,1]", "[1,1,1,3]")]
    [TestCase("[-1,4,-1]", "[-1,-1,4]")]
    [TestCase("[-100]", "[-100]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.ConstructTransformedArray(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
