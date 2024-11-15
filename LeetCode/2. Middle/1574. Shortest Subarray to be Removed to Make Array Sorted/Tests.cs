using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1574._Shortest_Subarray_to_be_Removed_to_Make_Array_Sorted;

[TestFixture(TestName = "1574. Shortest Subarray to be Removed to Make Array Sorted")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[11,26,3,14,24,6,10,16,32,9,36,24,27,17,31,32,35,36,11,22,30]", 17)]
    [TestCase("[1,2,3,10,0,7,8,9]", 2)]
    [TestCase("[1,2,3,4,2,3,4,5,2]", 5)]
    [TestCase("[1,2,2,2,2,2,3,1,7,5,1,2,2,2,2,2,2,5,6]", 5)]
    [TestCase("[1,2,3,10,4,2,3,5]", 3)]
    [TestCase("[5,4,3,2,1]", 4)]
    [TestCase("[5,1,2,3,4]", 1)]
    [TestCase("[1,2,3,4,1]", 1)]
    [TestCase("[1,2,3,4,2,3,4,5]", 2)]
    [TestCase("[1,2,3,4,5,2,3,4]", 3)]
    [TestCase("[1,2,3]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindLengthOfShortestSubarray(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
