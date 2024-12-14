using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._2._Middle._2762._Continuous_Subarrays;

[TestFixture(TestName = "2762. Continuous Subarrays")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[42,41,42,41,41,40,39,38]", 28)]
    [TestCase("[2,3,4,3,3,2,1,2,2,1]", 43)]
    [TestCase("[5,4,2,4]", 8)]
    [TestCase("[1,2,3]", 6)]
    public void Test(string input, long output)
    {
        var solution = new Solution();
        var actual = solution.ContinuousSubarrays(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        Test(input, output.ParseLong());
    }
}
