using System.Linq;
using System.Text.RegularExpressions;
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
                ? ConcatNonStrongSiblings(htmlNode.NextSibling)
                : htmlNode.ParentNode.LastChild.InnerText;
        }

        string ConcatNonStrongSiblings(HtmlNode htmlNode)
        {
            var result = htmlNode.InnerText;
            while (htmlNode.NextSibling != null && htmlNode.NextSibling.Name != "strong")
            {
                htmlNode = htmlNode.NextSibling;
                result += htmlNode.InnerText;
            }

            return result;
        }

        var inputExamples = doc.DocumentNode
            .SelectNodes("//strong[contains(text(), 'Input')]")
            .Select(GetExampleText)
            .Select(x => x.Trim().Split(", "))
            .ToArray();
        var outputExamples = doc.DocumentNode
            .SelectNodes("//strong[contains(text(), 'Output')]")
            .Select(GetExampleText)
            .ToArray();
        var examplesCount = inputExamples.Length;
        taskData.ExamplesCount = examplesCount;

        string HandleExample(string example)
        {
            var result = example.Replace("\"", "\\\"").Replace("&quot;", "\\\"");
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
                taskDataParam.Examples[i] = HandleExample(Regex.Split(inputExamples[i][j], @"\s*=\s*")[1]);
            }

            if (i == 0)
                taskData.Return.Examples = new string[examplesCount];
            taskData.Return.Examples[i] = HandleExample(outputExamples[i].Trim());
        }
    }
}