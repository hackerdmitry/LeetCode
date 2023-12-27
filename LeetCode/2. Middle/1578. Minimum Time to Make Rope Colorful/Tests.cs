using NUnit.Framework;

namespace LeetCode._2._Middle._1578._Minimum_Time_to_Make_Rope_Colorful;

[TestFixture(TestName = "1578. Minimum Time to Make Rope Colorful")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abaac", new[]{1,2,3,4,5}, 3)]
    [TestCase("abc", new[]{1,2,3}, 0)]
    [TestCase("aabaa", new[]{1,2,3,4,1}, 2)]
    [TestCase("bbbaaa", new[]{4,9,3,8,8,9}, 23)]
    public void Test(string input1, int[] input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinCost(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
