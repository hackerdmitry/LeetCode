using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._2._Middle._2975._Maximum_Square_Area_by_Removing_Fences_From_a_Field;

[TestFixture(TestName = "2975. Maximum Square Area by Removing Fences From a Field")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, 3, "[2,3]", "[2]", 4)]
    [TestCase(6, 7, "[2]", "[4]", -1)]
    public void Test(int input1, int input2, string input3, string input4, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximizeSquareArea(input1, input2, input3.ParseIntArray(), input4.ParseIntArray());
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        var inputs = input.Split('\n');
        Test(inputs[0].ParseInt(), inputs[1].ParseInt(), inputs[2], inputs[3], output.ParseInt());
    }
}
