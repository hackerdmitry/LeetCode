using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BuildTask.Enums;
using BuildTask.Models;
using BuildTask.Requests;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using Newtonsoft.Json;

namespace BuildTask;

public static class Program
{
    private static readonly GraphQLHttpClient graphQLClient = new("https://leetcode.com/graphql/", new NewtonsoftJsonSerializer());

    public static async Task Main()
    {
        Console.Write("Input title slug: ");
        var titleSlug = Console.ReadLine();
        var taskData = new TaskData();

        var questionContent = await new QuestionContentRequest(titleSlug).GetResponse(graphQLClient);

        await FillTaskData(titleSlug, taskData);
        await FillSampleCodeSnipper(titleSlug, taskData);
        await FillTestData(titleSlug, taskData);
        HtmlParser.ParseExamples(questionContent.Content, taskData);

        var builder = new Builder(taskData);

        var folderFactory = new FolderFactory(taskData);
        var taskFolderPath = folderFactory.CreateTaskFolderPath();
        try
        {
            await using var taskFileWriter = folderFactory.CreateTaskFile(taskFolderPath);
            builder.BuildTaskFile(taskFileWriter);
            await using var testsFileWriter = folderFactory.CreateTestsFile(taskFolderPath);
            builder.BuildTestsFile(testsFileWriter);
        }
        catch
        {
            Directory.Delete(taskFolderPath, true);
            throw;
        }

        // builder.BuildTaskFile(Console.Out);
        // builder.BuildTestsFile(Console.Out);
    }

    private static async Task FillTaskData(string titleSlug, TaskData taskData)
    {
        var questionTitle = await new QuestionTitleRequest(titleSlug).GetResponse(graphQLClient);
        taskData.Title = $"{questionTitle.QuestionFrontendId}. {questionTitle.Title}";
        taskData.Difficulty = questionTitle.Difficulty;
    }

    private static async Task FillSampleCodeSnipper(string titleSlug, TaskData taskData)
    {
        var questionEditorData = await new QuestionEditorDataRequest(titleSlug).GetResponse(graphQLClient);
        var codeSnippet = questionEditorData.CodeSnippets.FirstOrDefault(x => x.Lang == "C#");
        if (codeSnippet == null)
            throw new Exception("Code snippet for C# is not found");
        taskData.SampleCodeSnippet = Regex.Replace(codeSnippet.Code, @" {\n(    )( *)", "\n$2{\n$1");
        taskData.SampleCodeSnippet = Regex.Replace(taskData.SampleCodeSnippet, "(    )\n", "$1$1\n");
        taskData.SampleCodeSnippet = Regex.Replace(taskData.SampleCodeSnippet, @"\/\*.*\*\/\n", string.Empty, RegexOptions.Singleline);
    }

    private static async Task FillTestData(string titleSlug, TaskData taskData)
    {
        var consolePanelConfigResponse = await new ConsolePanelConfigRequest(titleSlug).GetResponse(graphQLClient);
        var metaData = JsonConvert.DeserializeObject<MetaData>(consolePanelConfigResponse.MetaData);

        taskData.Params = metaData.Params
            .Select((x, i) => TransformType(x.Type, metaData.Params.Length == 1 ? "input" : $"input{i + 1}"))
            .ToArray();
        taskData.Return = TransformType(metaData.Return.Type, "output");

        Console.WriteLine("Params:");
        foreach (var metaDataParam in metaData.Params)
            Console.WriteLine($"- {metaDataParam.Name}: {metaDataParam.Type}");
        Console.WriteLine("Return:");
        Console.WriteLine($"- {metaData.Return.Type}{(metaData.Return.Size.HasValue ? $", size={metaData.Return.Size}" : string.Empty)}");
    }

    private static VariableInfo TransformType(string type, string name)
    {
        type = type
            .Replace("integer", "int")
            .Replace("character", "char")
            .Replace("boolean", "bool");

        return new VariableInfo
        {
            Type = type,
            Name = name,
        };
    }
}