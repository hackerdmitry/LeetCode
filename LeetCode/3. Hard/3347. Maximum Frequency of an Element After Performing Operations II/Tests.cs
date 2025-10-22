using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._3._Hard._3347._Maximum_Frequency_of_an_Element_After_Performing_Operations_II;

[TestFixture(TestName = "3347. Maximum Frequency of an Element After Performing Operations II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,4,5]", 1, 2, 2)]
    [TestCase("[5,11,20,20]", 5, 1, 2)]
    public void Test(string input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxFrequency(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output, actual);
    }

    [Timeout(400)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        var inputs = input.Split(' ');
        Test(inputs[0], inputs[1].ParseInt(), inputs[2].ParseInt(), output.ParseInt());
    }
}
