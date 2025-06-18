using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2966._Divide_Array_Into_Arrays_With_Max_Difference;

[TestFixture(TestName = "2966. Divide Array Into Arrays With Max Difference")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,3,4,8,7,9,3,5,1]", 2, "[[1,1,3],[3,4,5],[7,8,9]]")]
    [TestCase("[2,4,2,2,5,2]", 2, "[]")]
    [TestCase("[4,2,9,8,2,12,7,12,10,5,8,5,5,7,9,2,5,11]", 14, "[[2,2,12],[4,8,5],[5,9,7],[7,8,5],[5,9,10],[11,12,2]]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.DivideArray(input1.ParseIntArray(), input2);
        Assert.AreEqual(output.ParseIntArray2d(), actual);
    }
}
