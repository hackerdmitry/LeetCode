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

        var inputExamples = doc.DocumentNode
            .SelectNodes("//strong[text() = 'Input:']")
            .Select(x => x.NextSibling.InnerText.Trim().Split(", "))
            .ToArray();
        var outputExamples = doc.DocumentNode
            .SelectNodes("//strong[text() = 'Output:']")
            .Select(x => x.NextSibling.InnerText)
            .ToArray();
        var examplesCount = inputExamples.Length;
        taskData.ExamplesCount = examplesCount;

        for (var i = 0; i < examplesCount; i++)
        {
            for (var j = 0; j < taskData.Params.Length; j++)
            {
                var taskDataParam = taskData.Params[j];
                if (i == 0)
                    taskDataParam.Examples = new string[examplesCount];
                taskDataParam.Examples[i] = inputExamples[i][j].Split(" = ")[1].Replace("&quot;", "\"").Trim('"');
            }

            if (i == 0)
                taskData.Return.Examples = new string[examplesCount];
            taskData.Return.Examples[i] = outputExamples[i].Trim();
        }
    }
}