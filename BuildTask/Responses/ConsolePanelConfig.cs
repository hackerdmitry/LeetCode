using Newtonsoft.Json;

namespace BuildTask.Responses;

public class ConsolePanelConfig
{
    [JsonProperty("questionId")]
    public string QuestionId { get; set; }

    [JsonProperty("questionFrontendId")]
    public string QuestionFrontendId { get; set; }

    [JsonProperty("questionTitle")]
    public string QuestionTitle { get; set; }

    [JsonProperty("enableDebugger")]
    public bool EnableDebugger { get; set; }

    [JsonProperty("enableRunCode")]
    public bool EnableRunCode { get; set; }

    [JsonProperty("enableSubmit")]
    public bool EnableSubmit { get; set; }

    [JsonProperty("enableTestMode")]
    public bool EnableTestMode { get; set; }

    [JsonProperty("exampleTestcaseList")]
    public string[] ExampleTestcaseList { get; set; }

    [JsonProperty("metaData")]
    public string MetaData { get; set; }
}