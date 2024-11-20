using NUnit.Framework;

namespace LeetCode._2._Middle._2516._Take_K_of_Each_Character_From_Left_and_Right;

[TestFixture(TestName = "2516. Take K of Each Character From Left and Right")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("aabaaaacaabc", 2, 8)]
    [TestCase("a", 1, -1)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.TakeCharacters(input1, input2);
        Assert.AreEqual(output, actual);
    }
}