using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2294._Partition_Array_Such_That_Maximum_Difference_Is_K;

[TestFixture(TestName = "2294. Partition Array Such That Maximum Difference Is K")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,6,1,2,5]", 2, 2)]
    [TestCase("[1,2,3]", 1, 2)]
    [TestCase("[2,2,4,5]", 0, 3)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.PartitionArray(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
