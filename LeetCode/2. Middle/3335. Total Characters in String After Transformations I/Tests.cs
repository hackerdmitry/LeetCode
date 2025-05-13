using NUnit.Framework;

namespace LeetCode._2._Middle._3335._Total_Characters_in_String_After_Transformations_I;

[TestFixture(TestName = "3335. Total Characters in String After Transformations I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abcyy", 2, 7)]
    [TestCase("azbk", 1, 5)]
    [TestCase("a", 51, 3)]
    [TestCase("a", 52, 4)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.LengthAfterTransformations(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
