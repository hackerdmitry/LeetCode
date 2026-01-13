using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._399._Evaluate_Division;

[TestFixture(TestName = "399. Evaluate Division")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[\"a\",\"b\"],[\"b\",\"c\"]]", "[2.0,3.0]", "[[\"a\",\"c\"],[\"b\",\"a\"],[\"a\",\"e\"],[\"a\",\"a\"],[\"x\",\"x\"]]", "[6.00000,0.50000,-1.00000,1.00000,-1.00000]")]
    [TestCase("[[\"a\",\"b\"],[\"b\",\"c\"],[\"bc\",\"cd\"]]", "[1.5,2.5,5.0]", "[[\"a\",\"c\"],[\"c\",\"b\"],[\"bc\",\"cd\"],[\"cd\",\"bc\"]]", "[3.75000,0.40000,5.00000,0.20000]")]
    [TestCase("[[\"a\",\"b\"]]", "[0.5]", "[[\"a\",\"b\"],[\"b\",\"a\"],[\"a\",\"c\"],[\"x\",\"y\"]]", "[0.50000,2.00000,-1.00000,-1.00000]")]
    public void Test(string input1, string input2, string input3, string output)
    {
        var solution = new Solution();
        var actual = solution.CalcEquation(input1.ParseStringArray2d(), input2.ParseDoubleArray(), input3.ParseStringArray2d());
        var expected = output.ParseDoubleArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}
