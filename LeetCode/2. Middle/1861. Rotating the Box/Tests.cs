using LeetCode.Extensions;
using LeetCode.Helpers;
using NUnit.Framework;

namespace LeetCode._2._Middle._1861._Rotating_the_Box;

[TestFixture(TestName = "1861. Rotating the Box")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[['#','.','*','.'], ['#','#','*','.']]", "[['#','.'],['#','#'],['*','*'],['.','.']]")]
    [TestCase("[['#','.','#']]", "[['.'],['#'],['#']]")]
    [TestCase("[['#','.'],['.','.']]", "[['.','.'],['.','#']]")]
    [TestCase("[['#','#','*','.','*','.'], ['#','#','#','*','.','.'], ['#','#','#','.','#','.']]", "[['.','#','#'],['.','#','#'],['#','#','*'],['#','*','.'],['#','.','*'],['#','.','.']]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var initial = input.ParseCharArray2d();
        initial.WriteLine("initial", "");
        var actual = solution.RotateTheBox(initial);
        var expected = output.ParseCharArray2d();
        actual.WriteLine("actual", "");
        expected.WriteLine("expected", "");
        Assert.AreEqual(expected, actual);
    }

    [Timeout(1000)]
    [TestCase("BigTest1")]
    public void BigTest(string folderName)
    {
        var (input, output) = ReaderHelper.ReadInputOutputFile(folderName);
        Test(input, output);
    }
}