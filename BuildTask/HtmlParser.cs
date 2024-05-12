using System.Linq;
using BuildTask.Enums;
using HtmlAgilityPack;

namespace BuildTask;

public class HtmlParser
{
    public static void ParseExamples(string html, TaskData taskData)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(html);

        string GetExampleText(HtmlNode htmlNode)
        {
            return htmlNode.ParentNode.Name == "pre"
                ? htmlNode.NextSibling.InnerText
                : htmlNode.ParentNode.LastChild.InnerText;
        }

        var inputExamples = doc.DocumentNode
            .SelectNodes("//strong[text() = 'Input:']")
            .Select(GetExampleText)
            .Select(x => x.Trim().Split(", "))
            .ToArray();
        var outputExamples = doc.DocumentNode
            .SelectNodes("//strong[text() = 'Output:']")
            .Select(GetExampleText)
            .ToArray();
        var examplesCount = inputExamples.Length;
        taskData.ExamplesCount = examplesCount;

        string HandleExample(string example)
        {
            var result = example.Replace("&quot;", "\\\"");
            if (result.StartsWith("\\\"") && result.StartsWith("\\\""))
                result = result.Substring(2, result.Length - 4);
            return result;
        }

        for (var i = 0; i < examplesCount; i++)
        {
            for (var j = 0; j < taskData.Params.Length; j++)
            {
                var taskDataParam = taskData.Params[j];
                if (i == 0)
                    taskDataParam.Examples = new string[examplesCount];
                taskDataParam.Examples[i] = HandleExample(inputExamples[i][j].Split(" = ")[1]);
            }

            if (i == 0)
                taskData.Return.Examples = new string[examplesCount];
            taskData.Return.Examples[i] = HandleExample(outputExamples[i].Trim());
        }
    }
}