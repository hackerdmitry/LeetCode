using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._1526._Minimum_Number_of_Increments_on_Subarrays_to_Form_a_Target_Array;

[TestFixture(TestName = "1526. Minimum Number of Increments on Subarrays to Form a Target Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,2,1]", 3)]
    [TestCase("[3,1,1,2]", 4)]
    [TestCase("[3,1,5,4,2]", 7)]
    [TestCase("[1,4,2,3,1]", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinNumberOperations(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
