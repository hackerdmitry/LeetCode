using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2657._Find_the_Prefix_Common_Array_of_Two_Arrays;

[TestFixture(TestName = "2657. Find the Prefix Common Array of Two Arrays")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,3,2,4]", "[3,1,2,4]", "[0,2,3,4]")]
    [TestCase("[2,3,1]", "[3,1,2]", "[0,1,3]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.FindThePrefixCommonArray(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
