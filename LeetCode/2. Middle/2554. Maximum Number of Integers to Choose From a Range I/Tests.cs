using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2554._Maximum_Number_of_Integers_to_Choose_From_a_Range_I;

[TestFixture(TestName = "2554. Maximum Number of Integers to Choose From a Range I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[87,193,85,55,14,69,26,133,171,180,4,8,29,121,182,78,157,53,26,7,117,138,57,167,8,103,32,110,15,190,139,16,49,138,68,69,92,89,140,149,107,104,2,135,193,87,21,194,192,9,161,188,73,84,83,31,86,33,138,63,127,73,114,32,66,64,19,175,108,80,176,52,124,94,33,55,130,147,39,76,22,112,113,136,100,134,155,40,170,144,37,43,151,137,82,127,73]", 1079, 87, 9)]
    [TestCase("[1,6,5]", 5, 6, 2)]
    [TestCase("[1,2,3,4,5,6,7]", 8, 1, 0)]
    [TestCase("[11]", 7, 50, 7)]
    public void Test(string input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxCount(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output, actual);
    }
}
