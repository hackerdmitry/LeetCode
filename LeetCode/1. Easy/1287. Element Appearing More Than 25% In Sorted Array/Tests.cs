using NUnit.Framework;

namespace LeetCode._1._Easy._1287._Element_Appearing_More_Than_25__In_Sorted_Array;

[TestFixture(TestName = "1287. Element Appearing More Than 25% In Sorted Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{1,2,2,6,6,6,6,7,10}, 6)]
    [TestCase(new[]{1,1}, 1)]
    [TestCase(new[]{1}, 1)]
    [TestCase(new[]{1,2,3,3}, 3)]
    [TestCase(new[]{1,2,2,2,2,2,3,3,3,3,3,3,4,4,4,4,5,5,5,5}, 3)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindSpecialInteger(input);
        Assert.AreEqual(output, actual);
    }
}
