using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._88._Merge_Sorted_Array;

[TestFixture(TestName = "88. Merge Sorted Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,5,6,0,0,0]", 3, "[1,2,3]", 3, "[1,2,3,4,5,6]")]
    [TestCase("[1,2,3,0,0,0]", 3, "[2,5,6]", 3, "[1,2,2,3,5,6]")]
    [TestCase("[1]", 1, "[]", 0, "[1]")]
    [TestCase("[0]", 0, "[1]", 1, "[1]")]
    public void Test(string input1, int input2, string input3, int input4, string output)
    {
        var solution = new Solution();
        var actual = input1.ParseIntArray();
        solution.Merge(actual, input2, input3.ParseIntArray(), input4);
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
