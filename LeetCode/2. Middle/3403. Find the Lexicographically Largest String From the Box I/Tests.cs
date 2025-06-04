using NUnit.Framework;

namespace LeetCode._2._Middle._3403._Find_the_Lexicographically_Largest_String_From_the_Box_I;

[TestFixture(TestName = "3403. Find the Lexicographically Largest String From the Box I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("aann", 2, "nn")]
    [TestCase("bif", 2, "if")]
    [TestCase("dbca", 2, "dbc")]
    [TestCase("gggg", 4, "g")]
    [TestCase("gh", 1, "gh")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.AnswerString(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
