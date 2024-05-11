using Newtonsoft.Json;

namespace BuildTask.Responses;

public class QuestionContent
{
    [JsonProperty("content")]
    public string Content { get; set; }
}