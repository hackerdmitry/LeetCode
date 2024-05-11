using System;
using System.IO;
using System.Linq;
using BuildTask.Enums;

namespace BuildTask;

public class FolderFactory
{
    public const string LeetCodeFolderName = "LeetCode";

    private const string solutionFileName = "Solution.cs";
    private const string testsFileName = "Tests.cs";

    private readonly TaskData taskData;
    private readonly string difficultyDirectoryName;

    public FolderFactory(TaskData taskData)
    {
        this.taskData = taskData;
        difficultyDirectoryName = GetDifficultyDirectoryName(taskData.Difficulty);
    }

    public string CreateTaskFolderPath()
    {
        var leetCodeDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
        while (leetCodeDirectory != null && leetCodeDirectory.Name != LeetCodeFolderName)
            leetCodeDirectory = leetCodeDirectory.Parent;
        if (leetCodeDirectory == null)
            throw new Exception($"Directory \"{LeetCodeFolderName}\" not found");
        leetCodeDirectory = leetCodeDirectory.EnumerateDirectories().FirstOrDefault(x => x.Name == LeetCodeFolderName);
        if (leetCodeDirectory == null)
            throw new Exception($"Directory \"{LeetCodeFolderName}\\{LeetCodeFolderName}\" not found");

        var difficultyDirectory = leetCodeDirectory.EnumerateDirectories().FirstOrDefault(x => x.Name == difficultyDirectoryName);
        if (difficultyDirectory == null)
            throw new Exception($"Directory \"{LeetCodeFolderName}\\{LeetCodeFolderName}\\{difficultyDirectoryName}\" not found");

        if (difficultyDirectory.EnumerateDirectories().Any(x => x.Name == taskData.Title))
            throw new Exception($"Directory \"{taskData.Title}\" already exists");

        var taskDirectory = difficultyDirectory.CreateSubdirectory(taskData.Title);
        return taskDirectory.FullName;
    }

    public StreamWriter CreateTaskFile(string taskFolderPath)
    {
        var fileName = Path.Combine(taskFolderPath, solutionFileName);
        var fileStream = File.Create(fileName);
        return new StreamWriter(fileStream);
    }

    public StreamWriter CreateTestsFile(string taskFolderPath)
    {
        var fileName = Path.Combine(taskFolderPath, testsFileName);
        var fileStream = File.Create(fileName);
        return new StreamWriter(fileStream);
    }

    public static string GetDifficultyDirectoryName(Difficulty difficulty) =>
        difficulty switch
        {
            Difficulty.Easy => "1. Easy",
            Difficulty.Medium => "2. Middle",
            Difficulty.Hard => "3. Hard",
        };
}