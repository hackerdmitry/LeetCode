using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2942._Find_Words_Containing_Character;

[TestFixture(TestName = "2942. Find Words Containing Character")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"leet\",\"code\"]", 'e', "[0,1]")]
    [TestCase("[\"abc\",\"bcd\",\"aaaa\",\"cbc\"]", 'a', "[0,2]")]
    [TestCase("[\"abc\",\"bcd\",\"aaaa\",\"cbc\"]", 'z', "[]")]
    public void Test(string input1, char input2, string output)
    {
        var solution = new Solution();
        var actual = solution.FindWordsContaining(input1.ParseStringArray(), input2);
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}