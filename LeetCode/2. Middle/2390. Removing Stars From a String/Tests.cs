using NUnit.Framework;

namespace LeetCode._2._Middle._2390._Removing_Stars_From_a_String;

[TestFixture(TestName = "2390. Removing Stars From a String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("leet**cod*e", "lecoe")]
    [TestCase("erase*****", "")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.RemoveStars(input);
        Assert.AreEqual(output, actual);
    }
}
