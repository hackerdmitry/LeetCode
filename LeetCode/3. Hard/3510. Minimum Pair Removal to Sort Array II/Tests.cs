using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._3._Hard._3510._Minimum_Pair_Removal_to_Sort_Array_II;

[TestFixture(TestName = "3510. Minimum Pair Removal to Sort Array II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,6,4,-6,2,-4,5,-7,-3,6,3,-4]", 10)]
    [TestCase("[-2,-1,1,-4,-5,2,-2,-5,-2,0,-2]", 9)]
    [TestCase("[-2,1,2,-1,-1,-2,-2,-1,-1,1,1]", 10)]
    [TestCase("[5,2,3,1]", 2)]
    [TestCase("[1,3,2,-1,2,-2,-1]", 5)]
    [TestCase("[5,5,3,2]", 1)]
    [TestCase("[1,2,2]", 0)]
    [TestCase("[15,17,1,2,3,4]", 4)]
    [TestCase("[17,15,1,2,3,4,1,4]", 6)]
    [TestCase("[15,17,1,2,3,4,1,4]", 7)]
    [TestCase("[2,2,-1,3,-2,2,1,1,1,0,-1]", 9)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumPairRemoval(input.ParseIntArray());
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
