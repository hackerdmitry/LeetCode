using NUnit.Framework;

namespace LeetCode._1._Easy._2490._Circular_Sentence;

[TestFixture(TestName = "2490. Circular Sentence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("leetcode exercises sound delightful", true)]
    [TestCase("eetcode", true)]
    [TestCase("Leetcode is cool", false)]
    [TestCase("eetcodE", false)]
    [TestCase("ee Ee", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsCircularSentence(input);
        Assert.AreEqual(output, actual);
    }
}
