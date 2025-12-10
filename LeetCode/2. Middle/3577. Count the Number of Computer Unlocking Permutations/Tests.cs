using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3577._Count_the_Number_of_Computer_Unlocking_Permutations;

[TestFixture(TestName = "3577. Count the Number of Computer Unlocking Permutations")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3]", 2)]
    [TestCase("[3,3,3,4,4,4]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountPermutations(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
