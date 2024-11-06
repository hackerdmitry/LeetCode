using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3011._Find_if_Array_Can_Be_Sorted;

[TestFixture(TestName = "3011. Find if Array Can Be Sorted")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,4,128,128,32,64,2,8,64,8,32,2,233,230,188,214,218,182,236,213,186,211,185,218,244]", true)]
    [TestCase("[75,34,30]", false)]
    [TestCase("[8,4,2,30,15]", true)]
    [TestCase("[1,2,3,4,5]", true)]
    [TestCase("[3,16,8,4,2]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.CanSortArray(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
