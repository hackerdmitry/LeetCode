using NUnit.Framework;

namespace LeetCode._2._Middle._2486._Append_Characters_to_String_to_Make_Subsequence;

[TestFixture(TestName = "2486. Append Characters to String to Make Subsequence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("coaching", "coding", 4)]
    [TestCase("abcde", "a", 0)]
    [TestCase("z", "abcde", 5)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.AppendCharacters(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
