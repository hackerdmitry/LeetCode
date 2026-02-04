using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._3._Hard._3640._Trionic_Array_II;

[TestFixture(TestName = "3640. Trionic Array II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[749,932,636,395,112,271,736,822,565,234,179,832,-127,689,-706,-862,477,86]", 4653)]
    [TestCase("[0,-2,-1,-3,0,2,-1]", -4)]
    [TestCase("[1,4,2,7]", 14)]
    [TestCase("[92,582,-953,778,-608,-627,476,-69,948,121,-696]", 728)]
    public void Test(string input, long output)
    {
        var solution = new Solution();
        var actual = solution.MaxSumTrionic(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }

    [Timeout(3000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        Test(input, output.ParseLong());
    }
}
