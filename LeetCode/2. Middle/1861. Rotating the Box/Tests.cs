using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using LeetCode.Extensions;
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
    public void BigTest(string folder)
    {
        var namespaceName = TestContext.CurrentContext.Test.ClassName!.Replace("LeetCode.", string.Empty);
        var numbersMatch = Regex.Matches(namespaceName, "\\d+");
        var difficultyFolderStartWith = Path.Combine(".", numbersMatch[0].Value);
        var difficultyFolder = Directory.GetDirectories(".").First(x => x.StartsWith(difficultyFolderStartWith));
        var taskFolderStartWith = Path.Combine(difficultyFolder, numbersMatch[1].Value);
        var taskFolder = Directory.GetDirectories(difficultyFolder).First(x => x.StartsWith(taskFolderStartWith));

        using var inputReader = new StreamReader(Path.Combine(taskFolder, folder, "input.txt"));
        using var outputReader = new StreamReader(Path.Combine(taskFolder, folder, "output.txt"));
        Test(inputReader.ReadToEnd().Trim(), outputReader.ReadToEnd().Trim());
    }
}