using NUnit.Framework;

namespace LeetCode._1._Easy._1935._Maximum_Number_of_Words_You_Can_Type;

[TestFixture(TestName = "1935. Maximum Number of Words You Can Type")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("hello world", "ad", 1)]
    [TestCase("leet code", "lt", 1)]
    [TestCase("leet code", "e", 0)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.CanBeTypedWords(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
