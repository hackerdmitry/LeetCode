using NUnit.Framework;

namespace LeetCode._1._Easy._1455._Check_If_a_Word_Occurs_As_a_Prefix_of_Any_Word_in_a_Sentence;

[TestFixture(TestName = "1455. Check If a Word Occurs As a Prefix of Any Word in a Sentence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("hellohello hellohellohello", "ell", -1)]
    [TestCase("i love eating burger", "burg", 4)]
    [TestCase("this problem is an easy problem", "pro", 2)]
    [TestCase("i am tired", "you", -1)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.IsPrefixOfWord(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
