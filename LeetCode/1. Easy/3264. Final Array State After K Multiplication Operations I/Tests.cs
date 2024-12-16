using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3264._Final_Array_State_After_K_Multiplication_Operations_I;

[TestFixture(TestName = "3264. Final Array State After K Multiplication Operations I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,1,3,5,6]", 5, 2, "[8,4,6,5,6]")]
    [TestCase("[1,2]", 3, 4, "[16,8]")]
    public void Test(string input1, int input2, int input3, string output)
    {
        var solution = new Solution();
        var actual = solution.GetFinalState(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
