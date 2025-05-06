using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1920._Build_Array_from_Permutation;

[TestFixture(TestName = "1920. Build Array from Permutation")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,2,1,5,3,4]", "[0,1,2,4,5,3]")]
    [TestCase("[5,0,1,2,3,4]", "[4,5,0,1,2,3]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.BuildArray(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
