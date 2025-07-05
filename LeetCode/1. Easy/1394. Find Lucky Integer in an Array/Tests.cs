using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1394._Find_Lucky_Integer_in_an_Array;

[TestFixture(TestName = "1394. Find Lucky Integer in an Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,2,3,4]", 2)]
    [TestCase("[1,2,2,3,3,3]", 3)]
    [TestCase("[2,2,2,3,3]", -1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindLucky(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}