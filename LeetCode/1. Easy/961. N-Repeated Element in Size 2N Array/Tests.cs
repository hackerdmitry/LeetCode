using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._961._N_Repeated_Element_in_Size_2N_Array;

[TestFixture(TestName = "961. N-Repeated Element in Size 2N Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,3]", 3)]
    [TestCase("[2,1,2,5,3,2]", 2)]
    [TestCase("[5,1,5,2,5,3,5,4]", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.RepeatedNTimes(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
