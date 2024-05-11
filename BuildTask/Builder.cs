using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using BuildTask.Enums;
using BuildTask.Helpers;

namespace BuildTask;

public class Builder
{
    private readonly string[] typesWithoutLibraries = {"int", "double", "string"};
    private readonly SortedDictionary<string, string[]> libraryTypes = new()
    {
        ["System.Collections.Generic"] = new[] {"IList"},
        ["LeetCode.__Additional"] = new[] {"ListNode", "TreeNode"},
    };

    private readonly Dictionary<string, Func<string, string>> parseFunctions = new()
    {
        ["string[]"] = name => $"ParseStringArray({name})",
        ["string[][]"] = name => $"ParseStringArray2d({name})",
        ["int[]"] = name => $"ParseIntArray({name})",
        ["int[][]"] = name => $"ParseIntArray2d({name})",
    };

    private readonly TaskData taskData;

    public Builder(TaskData taskData)
    {
        this.taskData = taskData;
    }

    public void BuildTaskFile(TextWriter writer)
    {
        AppendUsings(writer);
        AppendNamespaceLine(writer);
        AppendTaskCodeSnippet(writer);
    }

    public void BuildTestsFile(TextWriter writer)
    {
        AppendUsings(writer, new[] {"NUnit.Framework", "LeetCode.Extensions"});
        AppendNamespaceLine(writer);
        AppendTestsCodeSnippet(writer);
    }

    private void AppendUsings(TextWriter writer, string[] additionalUsings = null)
    {
        var typesUsed = new List<string>(taskData.Params.Select(x => x.Type)) {taskData.Return.Type}
            .Select(x => x.Replace("[]", string.Empty).Replace("[,]", string.Empty))
            .ToHashSet();

        foreach (var type in typesWithoutLibraries)
            typesUsed.Remove(type);

        if (typesUsed.Count > 0 || additionalUsings != null)
        {
            var usings = new List<string>(additionalUsings ?? Array.Empty<string>());

            foreach (var (library, types) in libraryTypes)
            {
                var beforeCount = typesUsed.Count;
                foreach (var type in types)
                    typesUsed.Remove(type);
                if (beforeCount != typesUsed.Count)
                    usings.Add(library);
            }

            if (typesUsed.Count > 0)
                throw new($"Found unknown types: {string.Join(", ", typesUsed)}");

            foreach (var @using in usings.OrderBy(x => x, new UsingsComparer()))
                writer.WriteLine($"using {@using};");
            writer.WriteLine();
        }
    }

    private void AppendNamespaceLine(TextWriter fileWriter)
    {
        var nonEncodedNamespace = $"{FolderFactory.LeetCodeFolderName}.{FolderFactory.GetDifficultyDirectoryName(taskData.Difficulty)}.{taskData.Title}";
        var namespaceWithLeadingDigits = nonEncodedNamespace.Replace(' ', '_').Replace('-', '_');
        var encodedNamespace = Regex.Replace(namespaceWithLeadingDigits, @"(\.|^)(\d)", "$1_$2");
        fileWriter.WriteLine($"namespace {encodedNamespace};");
        fileWriter.WriteLine();
    }

    private void AppendTaskCodeSnippet(TextWriter fileWriter)
    {
        fileWriter.WriteLine(taskData.SampleCodeSnippet);
    }

    private void AppendTestsCodeSnippet(TextWriter writer)
    {
        string WrapExample((VariableInfo, string) example) =>
            example.Item1.Type == "string" || parseFunctions.ContainsKey(example.Item1.Type)
                ? '"' + example.Item2 + '"'
                : example.Item2;

        writer.WriteLine($"[TestFixture(TestName = \"{taskData.Title}\")]");
        writer.WriteLine($"public class Tests");
        writer.WriteLine($"{{");
        writer.WriteLine($"    [Timeout(1000)]");

        for (var i = 0; i < taskData.ExamplesCount; i++)
        {
            var examples = new List<(VariableInfo, string)>(taskData.Params.Select(x => (x, x.Examples[i]))) {(taskData.Return, taskData.Return.Examples[i])};
            writer.WriteLine($"    [TestCase({string.Join(", ", examples.Select(WrapExample))})]");
        }

        writer.WriteLine($"    public void Test({GetTestMethodParams()})");
        writer.WriteLine($"    {{");
        writer.WriteLine($"        var solution = new Solution();");
        writer.WriteLine($"        var actual = solution.{GetSnippetMethodName()}({PassParams()});");
        writer.WriteLine($"        Assert.AreEqual({InvokeParseMethod(taskData.Return)}, actual);");
        writer.WriteLine($"    }}");
        writer.WriteLine($"}}");
    }

    private string GetTestMethodParams() =>
        string.Join(", ", taskData.Params.Concat(new[] {taskData.Return}).Select(x => $"{GetParamType(x.Type)} {x.Name}"));

    private string GetParamType(string type) =>
        parseFunctions.ContainsKey(type) ? "string" : type;

    private string PassParams() =>
        string.Join(", ", taskData.Params.Select(InvokeParseMethod));

    private string GetSnippetMethodName()
    {
        var lineWithMethodName = taskData.SampleCodeSnippet.Split('\n')[2];
        return Regex.Match(lineWithMethodName, @" (\w+)\(").Groups[1].Value;
    }

    private string InvokeParseMethod(VariableInfo param) =>
        parseFunctions.TryGetValue(param.Type, out var parseFunction)
            ? parseFunction(param.Name)
            : param.Name;
}