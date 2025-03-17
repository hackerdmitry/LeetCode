using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2206._Divide_Array_Into_Equal_Pairs;

[TestFixture(TestName = "2206. Divide Array Into Equal Pairs")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,2,3,2,2,2]", true)]
    [TestCase("[1,2,3,4]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.DivideArray(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
