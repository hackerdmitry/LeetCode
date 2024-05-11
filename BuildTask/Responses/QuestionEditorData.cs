using Newtonsoft.Json;

namespace BuildTask.Responses;

public class QuestionEditorData
{
    [JsonProperty("questionId")]
    public string QuestionId { get; set; }

    [JsonProperty("questionFrontendId")]
    public string QuestionFrontendId { get; set; }

    [JsonProperty("codeSnippets")]
    public CodeSnippet[] CodeSnippets { get; set; }

    [JsonProperty("envInfo")]
    public string EnvInfo { get; set; }

    [JsonProperty("enableRunCode")]
    public bool EnableRunCode { get; set; }
}

public class CodeSnippet
{
    [JsonProperty("lang")]
    public string Lang { get; set; }

    [JsonProperty("langSlug")]
    public string LangSlug { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }
}