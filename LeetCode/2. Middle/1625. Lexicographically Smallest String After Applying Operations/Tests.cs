using NUnit.Framework;

namespace LeetCode._2._Middle._1625._Lexicographically_Smallest_String_After_Applying_Operations;

[TestFixture(TestName = "1625. Lexicographically Smallest String After Applying Operations")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("5525", 9, 2, "2050")]
    [TestCase("74", 5, 1, "24")]
    [TestCase("0011", 4, 2, "0011")]
    public void Test(string input1, int input2, int input3, string output)
    {
        var solution = new Solution();
        var actual = solution.FindLexSmallestString(input1, input2, input3);
        Assert.AreEqual(output, actual);
    }
}