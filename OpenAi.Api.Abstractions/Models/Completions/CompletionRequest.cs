using Newtonsoft.Json;

namespace OpenAi.Api.Abstractions.Models.Completions;

public class CompletionRequest
{
    public CompletionRequest(string model, string prompt)
    {
        Model = model;
        Prompt = prompt;
    }

    [JsonProperty("model")]
    public string Model { get; set; }

    [JsonProperty("prompt")]
    public string Prompt { get; set; }

    [JsonProperty("max_tokens")]
    public int MaxTokens { get; set; } = 16;
}