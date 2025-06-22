using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2138._Divide_a_String_Into_Groups_of_Size_k;

[TestFixture(TestName = "2138. Divide a String Into Groups of Size k")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abcdefghi", 3, 'x', "[\"abc\",\"def\",\"ghi\"]")]
    [TestCase("abcdefghij", 3, 'x', "[\"abc\",\"def\",\"ghi\",\"jxx\"]")]
    public void Test(string input1, int input2, char input3, string output)
    {
        var solution = new Solution();
        var actual = solution.DivideString(input1, input2, input3);
        Assert.AreEqual(output.ParseStringArray(), actual);
    }
}
