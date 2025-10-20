using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2011._Final_Value_of_Variable_After_Performing_Operations;

[TestFixture(TestName = "2011. Final Value of Variable After Performing Operations")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"--X\",\"X++\",\"X++\"]", 1)]
    [TestCase("[\"++X\",\"++X\",\"X++\"]", 3)]
    [TestCase("[\"X++\",\"++X\",\"--X\",\"X--\"]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.FinalValueAfterOperations(input.ParseStringArray());
        Assert.AreEqual(output, actual);
    }
}
