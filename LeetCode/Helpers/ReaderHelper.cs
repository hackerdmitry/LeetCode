using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace LeetCode.Helpers;

public class ReaderHelper
{
    public static (string Input, string Output) ReadInputOutputFile(string folderName)
    {
        var namespaceName = TestContext.CurrentContext.Test.ClassName!.Replace("LeetCode.", string.Empty);
        var numbersMatch = Regex.Matches(namespaceName, "\\d+");
        var difficultyFolderStartWith = Path.Combine(".", numbersMatch[0].Value);
        var difficultyFolder = Directory.GetDirectories(".").First(x => x.StartsWith(difficultyFolderStartWith));
        var taskFolderStartWith = Path.Combine(difficultyFolder, numbersMatch[1].Value);
        var taskFolder = Directory.GetDirectories(difficultyFolder).First(x => x.StartsWith(taskFolderStartWith));

        using var inputReader = new StreamReader(Path.Combine(taskFolder, folderName, "input.txt"));
        using var outputReader = new StreamReader(Path.Combine(taskFolder, folderName, "output.txt"));
        return (inputReader.ReadToEnd().Trim(), outputReader.ReadToEnd().Trim());
    }
}