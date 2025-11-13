using NUnit.Framework;

namespace LeetCode._2._Middle._3228._Maximum_Number_of_Operations_to_Move_Ones_to_the_End;

[TestFixture(TestName = "3228. Maximum Number of Operations to Move Ones to the End")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("1001101", 4)]
    [TestCase("00111", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxOperations(input);
        Assert.AreEqual(output, actual);
    }
}
