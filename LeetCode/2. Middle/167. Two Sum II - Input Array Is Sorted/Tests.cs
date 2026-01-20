using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._167._Two_Sum_II___Input_Array_Is_Sorted;

[TestFixture(TestName = "167. Two Sum II - Input Array Is Sorted")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,7,11,15]", 9, "[1,2]")]
    [TestCase("[2,3,4]", 6, "[1,3]")]
    [TestCase("[-1,0]", -1, "[1,2]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.TwoSum(input1.ParseIntArray(), input2);
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
