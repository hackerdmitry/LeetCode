using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2154._Keep_Multiplying_Found_Values_by_Two;

[TestFixture(TestName = "2154. Keep Multiplying Found Values by Two")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,3,6,1,12]", 3, 24)]
    [TestCase("[2,7,9]", 4, 4)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.FindFinalValue(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
