using System.Collections.Generic;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1002._Find_Common_Characters;

[TestFixture(TestName = "1002. Find Common Characters")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"bella\",\"label\",\"roller\"]", "[\"e\",\"l\",\"l\"]")]
    [TestCase("[\"cool\",\"lock\",\"cook\"]", "[\"c\",\"o\"]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.CommonChars(input.ParseStringArray());
        Assert.AreEqual(output.ParseStringArray(), actual);
    }
}
