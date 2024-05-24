using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._1255._Maximum_Score_Words_Formed_by_Letters;

[TestFixture(TestName = "1255. Maximum Score Words Formed by Letters")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"dog\",\"cat\",\"dad\",\"good\"]", new[]{'a','a','c','d','d','d','g','o','o'}, "[1,0,9,5,0,0,3,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0]", 23)]
    [TestCase("[\"xxxz\",\"ax\",\"bx\",\"cx\"]", new[]{'z','a','b','c','x','x','x'}, "[4,4,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,5,0,10]", 27)]
    [TestCase("[\"leetcode\"]", new[]{'l','e','t','c','o','d'}, "[0,0,1,1,1,0,0,0,0,0,0,1,0,0,1,0,0,0,0,1,0,0,0,0,0,0]", 0)]
    public void Test(string input1, char[] input2, string input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxScoreWords(input1.ParseStringArray(), input2, input3.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
