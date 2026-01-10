using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._724._Find_Pivot_Index;

[TestFixture(TestName = "724. Find Pivot Index")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[-1,-1,-1,-1,-1,0]", 2)]
    [TestCase("[1,7,3,6,5,6]", 3)]
    [TestCase("[1,2,3]", -1)]
    [TestCase("[2,1,-1]", 0)]
    [TestCase("[0,0]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.PivotIndex(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
