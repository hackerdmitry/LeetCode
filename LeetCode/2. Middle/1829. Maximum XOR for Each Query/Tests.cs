using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1829._Maximum_XOR_for_Each_Query;

[TestFixture(TestName = "1829. Maximum XOR for Each Query")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,1,1,3]", 2, "[0,3,2,3]")]
    [TestCase("[2,3,4,7]", 3, "[5,2,6,5]")]
    [TestCase("[0,1,2,2,5,7]", 3, "[4,3,6,4,6,7]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var intArray = input1.ParseIntArray();
        var actual = solution.GetMaximumXor(intArray, input2);
        actual.WriteLine("actual");
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}
