using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._68._Text_Justification;

[TestFixture(TestName = "68. Text Justification")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"This\", \"is\", \"an\", \"example\", \"of\", \"text\", \"justification.\"]", 16, "[\"This    is    an\",\"example  of text\",\"justification.  \"]")]
    [TestCase("[\"What\",\"must\",\"be\",\"acknowledgment\",\"shall\",\"be\"]", 16, "[\"What   must   be\",\"acknowledgment  \",\"shall be        \"]")]
    [TestCase("[\"Science\",\"is\",\"what\",\"we\",\"understand\",\"well\",\"enough\",\"to\",\"explain\",\"to\",\"a\",\"computer.\",\"Art\",\"is\",\"everything\",\"else\",\"we\",\"do\"]", 20, "[\"Science  is  what we\",\"understand      well\",\"enough to explain to\",\"a  computer.  Art is\",\"everything  else  we\",\"do                  \"]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.FullJustify(input1.ParseStringArray(), input2);
        var expected = output.ParseStringArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
