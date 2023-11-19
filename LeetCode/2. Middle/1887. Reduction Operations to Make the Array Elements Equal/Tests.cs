using NUnit.Framework;

namespace LeetCode._2._Middle._1887._Reduction_Operations_to_Make_the_Array_Elements_Equal;

[TestFixture(TestName = "1887. Reduction Operations to Make the Array Elements Equal")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{5,1,3}, 3)]
    [TestCase(new[]{1,1,1}, 0)]
    [TestCase(new[]{1,1,2,2,3}, 4)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.ReductionOperations(input);
        Assert.AreEqual(output, actual);
    }
}
