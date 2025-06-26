using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2200._Find_All_K_Distant_Indices_in_an_Array;

[TestFixture(TestName = "2200. Find All K-Distant Indices in an Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,4,9,1,3,9,5]", 9, 1, "[1,2,3,4,5,6]")]
    [TestCase("[2,2,2,2,2]", 2, 2, "[0,1,2,3,4]")]
    public void Test(string input1, int input2, int input3, string output)
    {
        var solution = new Solution();
        var actual = solution.FindKDistantIndices(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
