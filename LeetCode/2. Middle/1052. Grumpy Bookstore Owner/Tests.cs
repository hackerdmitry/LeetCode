using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1052._Grumpy_Bookstore_Owner;

[TestFixture(TestName = "1052. Grumpy Bookstore Owner")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,0,1,2,1,1,7,5]", "[0,1,0,1,0,1,0,1]", 3, 16)]
    [TestCase("[1]", "[0]", 1, 1)]
    public void Test(string input1, string input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxSatisfied(input1.ParseIntArray(), input2.ParseIntArray(), input3);
        Assert.AreEqual(output, actual);
    }
}
