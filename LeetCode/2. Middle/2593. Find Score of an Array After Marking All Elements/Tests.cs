using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2593._Find_Score_of_an_Array_After_Marking_All_Elements;

[TestFixture(TestName = "2593. Find Score of an Array After Marking All Elements")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,1,3,4,5,2]", 7)]
    [TestCase("[2,3,5,1,3,2]", 5)]
    public void Test(string input, long output)
    {
        var solution = new Solution();
        var actual = solution.FindScore(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
