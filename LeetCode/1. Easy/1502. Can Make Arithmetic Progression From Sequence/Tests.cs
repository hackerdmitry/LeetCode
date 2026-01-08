using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1502._Can_Make_Arithmetic_Progression_From_Sequence;

[TestFixture(TestName = "1502. Can Make Arithmetic Progression From Sequence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,5,1]", true)]
    [TestCase("[1,2,4]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.CanMakeArithmeticProgression(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
