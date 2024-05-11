using Newtonsoft.Json;

namespace BuildTask.Responses;

public class Data<TQuestion>
{
    [JsonProperty("question")]
    public TQuestion Question { get; set; }
}