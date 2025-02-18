using NUnit.Framework;

namespace LeetCode._2._Middle._2375._Construct_Smallest_Number_From_DI_String;

[TestFixture(TestName = "2375. Construct Smallest Number From DI String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("IIIDIDDD", "123549876")]
    [TestCase("DDD", "4321")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.SmallestNumber(input);
        Assert.AreEqual(output, actual);
    }
}
