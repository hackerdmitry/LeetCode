using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1268._Search_Suggestions_System;

[TestFixture(TestName = "1268. Search Suggestions System")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"mobile\",\"mouse\",\"moneypot\",\"monitor\",\"mousepad\"]", "mouse", "[[\"mobile\",\"moneypot\",\"monitor\"],[\"mobile\",\"moneypot\",\"monitor\"],[\"mouse\",\"mousepad\"],[\"mouse\",\"mousepad\"],[\"mouse\",\"mousepad\"]]")]
    [TestCase("[\"havana\"]", "havana", "[[\"havana\"],[\"havana\"],[\"havana\"],[\"havana\"],[\"havana\"],[\"havana\"]]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.SuggestedProducts(input1.ParseStringArray(), input2);
        Assert.AreEqual(output.ParseStringArray2d(), actual);
    }
}
