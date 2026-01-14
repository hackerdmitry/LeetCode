using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._215._Kth_Largest_Element_in_an_Array;

[TestFixture(TestName = "215. Kth Largest Element in an Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,2,1,5,6,4]", 2, 5)]
    [TestCase("[3,2,3,1,2,4,5,5,6]", 4, 4)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.FindKthLargest(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
