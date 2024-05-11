using BuildTask.Enums;
using Newtonsoft.Json;

namespace BuildTask.Responses;

public class QuestionTitle
{
    [JsonProperty("questionId")]
    public string QuestionId { get; set; }

    [JsonProperty("questionFrontendId")]
    public string QuestionFrontendId { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("titleSlug")]
    public string TitleSlug { get; set; }

    [JsonProperty("isPaidOnly")]
    public bool IsPaidOnly { get; set; }

    [JsonProperty("difficulty")]
    public Difficulty Difficulty { get; set; }

    [JsonProperty("likes")]
    public int Likes { get; set; }

    [JsonProperty("dislikes")]
    public int Dislikes { get; set; }
}