using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._189._Rotate_Array;

[TestFixture(TestName = "189. Rotate Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1]", 1, "[1]")]
    [TestCase("[1,2,3,4,5,6,7]", 3, "[5,6,7,1,2,3,4]")]
    [TestCase("[-1,-100,3,99]", 2, "[3,99,-1,-100]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = input1.ParseIntArray();
        solution.Rotate(actual, input2);
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
