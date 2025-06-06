using NUnit.Framework;

namespace LeetCode._2._Middle._2434._Using_a_Robot_to_Print_the_Lexicographically_Smallest_String;

[TestFixture(TestName = "2434. Using a Robot to Print the Lexicographically Smallest String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("zza", "azz")]
    [TestCase("bac", "abc")]
    [TestCase("bdda", "addb")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.RobotWithString(input);
        Assert.AreEqual(output, actual);
    }
}
