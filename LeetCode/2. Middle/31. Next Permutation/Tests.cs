using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._31._Next_Permutation;

[TestFixture(TestName = "31. Next Permutation")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,4,7,5,3,2]", "[5,5,2,3,4,7]")]
    [TestCase("[3,2,1]", "[1,2,3]")]
    [TestCase("[1,1]", "[1,1]")]
    [TestCase("[1,3,2]", "[2,1,3]")]
    [TestCase("[1,2,3]", "[1,3,2]")]
    [TestCase("[1,1,5]", "[1,5,1]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = input.ParseIntArray();
        solution.NextPermutation(actual);
        actual.WriteLine("actual");
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}
