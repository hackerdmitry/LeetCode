using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3828._Final_Element_After_Subarray_Deletions;

[TestFixture(TestName = "3828. Final Element After Subarray Deletions")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,5,2]", 2)]
    [TestCase("[3,7]", 7)]
    [TestCase("[10,6,10,7]", 10)]
    [TestCase("[7,10,6,10]", 10)]
    [TestCase("[6,10,6,7]", 7)]
    [TestCase("[7,6,10,6]", 7)]
    [TestCase("[6,10,7,10,6]", 6)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.FinalElement(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
