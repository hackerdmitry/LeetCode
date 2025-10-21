using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3346._Maximum_Frequency_of_an_Element_After_Performing_Operations_I;

[TestFixture(TestName = "3346. Maximum Frequency of an Element After Performing Operations I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[11,71,47]", 69, 1, 2)]
    [TestCase("[1,4,5]", 1, 2, 2)]
    [TestCase("[5,11,20,20]", 5, 1, 2)]
    [TestCase("[1,1,3]", 0, 1, 2)]
    [TestCase("[1,2,3]", 0, 2, 1)]
    public void Test(string input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxFrequency(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output, actual);
    }
}
