using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._3._Hard._2402._Meeting_Rooms_III;

[TestFixture(TestName = "2402. Meeting Rooms III")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, "[[18,19],[3,12],[17,19],[2,13],[7,10]]", 0)]
    [TestCase(2, "[[0,10],[1,5],[2,7],[3,4]]", 0)]
    [TestCase(3, "[[1,20],[2,10],[3,5],[4,9],[6,8]]", 1)]
    [TestCase(2, "[[0,10],[1,5],[2,7]]", 1)]
    public void Test(int input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MostBooked(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        var inputs = input.Split(' ');
        Test(inputs[0].ParseInt(), inputs[1], output.ParseInt());
    }
}
