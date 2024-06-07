using System.Collections.Generic;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._648._Replace_Words;

[TestFixture(TestName = "648. Replace Words")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"cat\",\"bat\",\"rat\"]", "the cattle was rattled by the battery", "the cat was rat by the bat")]
    [TestCase("[\"a\",\"b\",\"c\"]", "aadsfasf absbs bbab cadsfafs", "a a b c")]
    [TestCase("[\"a\",\"aa\",\"aaa\",\"aaaa\"]", "a aa a aaaa aaa aaa aaa aaaaaa bbb baba ababa", "a a a a a a a a bbb baba a")]
    [TestCase("[\"catt\",\"cat\",\"bat\",\"rat\"]", "the cattle was rattled by the battery", "the cat was rat by the bat")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.ReplaceWords(input1.ParseStringArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
