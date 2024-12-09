using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3152._Special_Array_II;

[TestFixture(TestName = "3152. Special Array II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,3,1,6]", "[[0,2],[2,3]]", new[]{false,true})]
    [TestCase("[3,4,1,2,6]", "[[0,4]]", new[]{false})]
    public void Test(string input1, string input2, bool[] output)
    {
        var solution = new Solution();
        var actual = solution.IsArraySpecial(input1.ParseIntArray(), input2.ParseIntArray2d());
        actual.WriteLine("actual");
        output.WriteLine("expected");
        Assert.AreEqual(output, actual);
    }
}
