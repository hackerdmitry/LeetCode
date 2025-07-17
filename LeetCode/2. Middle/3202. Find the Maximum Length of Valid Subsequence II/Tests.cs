using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._2._Middle._3202._Find_the_Maximum_Length_of_Valid_Subsequence_II;

[TestFixture(TestName = "3202. Find the Maximum Length of Valid Subsequence II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5]", 2, 5)]
    [TestCase("[1,4,2,3,1,4]", 3, 4)]
    [TestCase("[2,1,4,1,3]", 3, 3)]
    [TestCase("[3,2,1,9,1]", 6, 4)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumLength(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        var inputs = input.Split(' ');
        Test(inputs[0], inputs[1].ParseInt(), output.ParseInt());
    }
}
