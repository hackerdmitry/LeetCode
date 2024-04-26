using NUnit.Framework;

namespace LeetCode._2._Middle._33._Search_in_Rotated_Sorted_Array;

[TestFixture(TestName = "33. Search in Rotated Sorted Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{4,5,6,7,0,1,2}, 0, 4)]
    [TestCase(new[]{4,5,6,7,0,1,2}, 3, -1)]
    [TestCase(new[]{1}, 0, -1)]
    public void Test(int[] input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.Search(input1, input2);
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [TestCase(new[]{0,1,2,3}, 0)]
    [TestCase(new[]{3,0,1,2}, 1)]
    [TestCase(new[]{2,3,0,1}, 2)]
    [TestCase(new[]{1,2,3,0}, 3)]
    [TestCase(new[]{0,1,2}, 0)]
    [TestCase(new[]{2,0,1}, 1)]
    [TestCase(new[]{1,2,0}, 2)]
    public void TestFindShift(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindShift(input);
        Assert.AreEqual(output, actual);
    }
}
