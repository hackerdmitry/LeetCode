using NUnit.Framework;

namespace LeetCode._1._Easy._2000._Reverse_Prefix_of_Word;

[TestFixture(TestName = "2000. Reverse Prefix of Word")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abcdefd", 'd', "dcbaefd")]
    [TestCase("xyxzxe", 'z', "zxyxxe")]
    [TestCase("abcd", 'z', "abcd")]
    public void Test(string input1, char input2, string output)
    {
        var solution = new Solution();
        var actual = solution.ReversePrefix(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
