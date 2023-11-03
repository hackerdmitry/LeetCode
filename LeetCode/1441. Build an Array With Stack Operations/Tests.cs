using NUnit.Framework;

namespace LeetCode._1441._Build_an_Array_With_Stack_Operations;

[TestFixture(TestName = "1441. Build an Array With Stack Operations")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{1,3}, 3, new[]{"Push","Push","Pop","Push"})]
    [TestCase(new[]{1,2,3}, 3, new[]{"Push","Push","Push"})]
    [TestCase(new[]{1,2}, 4, new[]{"Push","Push"})]
    public void Test(int[] input1, int input2, string[] output)
    {
        var solution = new Solution();
        var actual = solution.BuildArray(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
