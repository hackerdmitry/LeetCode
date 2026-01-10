using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._643._Maximum_Average_Subarray_I;

[TestFixture(TestName = "643. Maximum Average Subarray I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,12,-5,-6,50,3]", 4, 12.75000)]
    [TestCase("[5]", 1, 5.00000)]
    public void Test(string input1, int input2, double output)
    {
        var solution = new Solution();
        var actual = solution.FindMaxAverage(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual, 10e-5);
    }
}
