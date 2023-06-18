using Newtonsoft.Json;

namespace OpenAi.Api.Abstractions.Models.Edits;

public class Model
{
    [JsonProperty("object", NullValueHandling = NullValueHandling.Ignore)]
    public string? Object { get; set; }

    [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
    public long? Created { get; set; }

    [JsonProperty("choices", NullValueHandling = NullValueHandling.Ignore)]
    public List<Choice>? Choices { get; set; }

    [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
    public Usage? Usage { get; set; }
}

public class Choice
{
    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; }

    [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
    public long? Index { get; set; }
}

public class Usage
{
    [JsonProperty("prompt_tokens", NullValueHandling = NullValueHandling.Ignore)]
    public long? PromptTokens { get; set; }

    [JsonProperty("completion_tokens", NullValueHandling = NullValueHandling.Ignore)]
    public long? CompletionTokens { get; set; }

    [JsonProperty("total_tokens", NullValueHandling = NullValueHandling.Ignore)]
    public long? TotalTokens { get; set; }
}