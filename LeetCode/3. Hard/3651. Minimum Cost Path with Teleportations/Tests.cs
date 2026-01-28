using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._3._Hard._3651._Minimum_Cost_Path_with_Teleportations;

[TestFixture(TestName = "3651. Minimum Cost Path with Teleportations")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,1,2],[1,2,2],[2,2,3]]", 1, 6)]
    [TestCase("[[6,11,8,16,23,3,3,11,19],[32,39,40,15,19,24,40,22,38],[47,24,46,33,14,44,17,27,21]]", 2, 24)]
    [TestCase("[[16,15,13],[13,23,22]]", 9, 22)]
    [TestCase("[[1,3,3],[2,5,4],[4,3,5]]", 2, 7)]
    [TestCase("[[1,1,2],[1,2,2],[2,2,3]]", 0, 8)]
    [TestCase("[[1,1,2],[1,2,2],[2,2,3]]", 2, 5)]
    [TestCase("[[1,2],[2,3],[3,4]]", 1, 9)]
    [TestCase("[[1,100],[100,1]]", 1, 0)]
    [TestCase("[[5,1],[4,3]]", 1, 0)]
    [TestCase("[[10,100,1],[100,100,100]]", 2, 100)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinCost(input1.ParseIntArray2d(), input2);
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    [TestCase("BigTest2")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        var inputs = input.Split('\n');
        Test(inputs[0], inputs[1].ParseInt(), output.ParseInt());
    }
}
