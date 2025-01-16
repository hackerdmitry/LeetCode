using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2425._Bitwise_XOR_of_All_Pairings;

[TestFixture(TestName = "2425. Bitwise XOR of All Pairings")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,1,3]", "[10,2,5,0]", 13)]
    [TestCase("[1,2]", "[3,4]", 0)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.XorAllNums(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
