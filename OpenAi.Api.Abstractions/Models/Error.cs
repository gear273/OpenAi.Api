using Newtonsoft.Json;

namespace OpenAi.Api.Abstractions.Models;

public class Error
{
    [JsonProperty("message")]
    public string? Message { get; set; }

    [JsonProperty("type")]
    public string? Type { get; set; }

    [JsonProperty("param")]
    public string? Parameters { get; set; }

    [JsonProperty("code")]
    public string? Code { get; set; }

}