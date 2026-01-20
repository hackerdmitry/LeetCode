using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._134._Gas_Station;

[TestFixture(TestName = "134. Gas Station")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5]", "[3,4,5,1,2]", 3)]
    [TestCase("[2,3,4]", "[3,4,3]", -1)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.CanCompleteCircuit(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
