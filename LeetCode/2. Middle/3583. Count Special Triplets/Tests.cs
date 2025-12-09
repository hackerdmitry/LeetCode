using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._2._Middle._3583._Count_Special_Triplets;

[TestFixture(TestName = "3583. Count Special Triplets")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,2,2]", 0)]
    [TestCase("[2,2,1,1]", 0)]
    [TestCase("[1,2,2,1,2,2]", 4)]
    [TestCase("[2,2,2,1,2,2,2]", 9)]
    [TestCase("[2,2,1,2,2,2,2]", 8)]
    [TestCase("[2,2,2,1,1,2,1,1]", 6)]
    [TestCase("[8,4,2,8,4,8,4]", 6)]
    [TestCase("[6,3,6]", 1)]
    [TestCase("[0,1,0,0]", 1)]
    [TestCase("[8,4,2,8,4]", 2)]
    [TestCase("[0,0,0,0,0,0]", 20)]
    [TestCase("[2,1,1,2]", 2)]
    [TestCase("[1,2,1,2]", 1)]
    [TestCase("[2,1,2,1]", 1)]
    [TestCase("[1,2,1,2,1]", 1)]
    [TestCase("[1,2,2,1]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.SpecialTriplets(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    [TestCase("BigTest2")]
    [TestCase("BigTest3")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        Test(input, output.ParseInt());
    }
}
