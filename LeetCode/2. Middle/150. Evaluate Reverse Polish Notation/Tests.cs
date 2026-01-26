using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._150._Evaluate_Reverse_Polish_Notation;

[TestFixture(TestName = "150. Evaluate Reverse Polish Notation")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"2\",\"1\",\"+\",\"3\",\"*\"]", 9)]
    [TestCase("[\"4\",\"13\",\"5\",\"/\",\"+\"]", 6)]
    [TestCase("[\"10\",\"6\",\"9\",\"3\",\"+\",\"-11\",\"*\",\"/\",\"*\",\"17\",\"+\",\"5\",\"+\"]", 22)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.EvalRPN(input.ParseStringArray());
        Assert.AreEqual(output, actual);
    }
}
