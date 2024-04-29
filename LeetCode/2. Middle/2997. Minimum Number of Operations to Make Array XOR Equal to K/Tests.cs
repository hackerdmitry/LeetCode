using NUnit.Framework;

namespace LeetCode._2._Middle._2997._Minimum_Number_of_Operations_to_Make_Array_XOR_Equal_to_K;

[TestFixture(TestName = "2997. Minimum Number of Operations to Make Array XOR Equal to K")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{2,1,3,4}, 1, 2)]
    [TestCase(new[]{2,0,2,0}, 0, 0)]
    public void Test(int[] input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinOperations(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
