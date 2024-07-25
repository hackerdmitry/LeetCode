using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._912._Sort_an_Array;

[TestFixture(TestName = "912. Sort an Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,2,3,1]", "[1,2,3,5]")]
    [TestCase("[5,1,1,2,0,0]", "[0,0,1,1,2,5]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.SortArray(input.ParseIntArray());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
