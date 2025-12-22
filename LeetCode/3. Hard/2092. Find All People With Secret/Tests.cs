using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._3._Hard._2092._Find_All_People_With_Secret;

[TestFixture(TestName = "2092. Find All People With Secret")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(6, "[[1,2,5],[2,3,8],[1,5,10]]", 1, "[0,1,2,3,5]")]
    [TestCase(4, "[[3,1,3],[1,2,2],[0,3,3]]", 3, "[0,1,3]")]
    [TestCase(5, "[[3,4,2],[1,2,1],[2,3,1]]", 1, "[0,1,2,3,4]")]
    [TestCase(5, "[[4,3,0],[1,2,1],[3,2,1],[3,4,2]]", 1, "[0,1,2,3,4]")]
    public void Test(int input1, string input2, int input3, string output)
    {
        var solution = new Solution();
        var actual = solution.FindAllPeople(input1, input2.ParseIntArray2d(), input3);
        var expected = output.ParseIntArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        var inputs = input.Split('\n');
        Test(inputs[0].ParseInt(), inputs[1], inputs[2].ParseInt(), output);
    }
}
