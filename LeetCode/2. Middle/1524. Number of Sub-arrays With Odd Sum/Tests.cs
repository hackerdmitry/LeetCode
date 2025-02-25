using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._2._Middle._1524._Number_of_Sub_arrays_With_Odd_Sum;

[TestFixture(TestName = "1524. Number of Sub-arrays With Odd Sum")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5,6,7]", 16)]
    [TestCase("[2,4,6]", 0)]
    [TestCase("[1,3,5]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumOfSubarrays(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        Test(input, output.ParseInt());
    }
}
