using Newtonsoft.Json;

namespace OpenAi.Api.Abstractions.Models;

public class Model
{
    #region Public Properties

    [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
    public long? Created { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; }

    [JsonProperty("object?", NullValueHandling = NullValueHandling.Ignore)]
    public string? Object { get; set; }
    [JsonProperty("owned_by", NullValueHandling = NullValueHandling.Ignore)]
    public string? OwnedBy { get; set; }

    [JsonProperty("parent")]
    public object? Parent { get; set; }

    [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
    public List<Permission> Permission { get; set; }

    [JsonProperty("root", NullValueHandling = NullValueHandling.Ignore)]
    public string? Root { get; set; }

    #endregion Public Properties
}

public class Permission
{
    #region Public Properties

    [JsonProperty("allow_create_engine", NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowCreateEngine { get; set; }

    [JsonProperty("allow_fine_tuning", NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowFineTuning { get; set; }

    [JsonProperty("allow_logprobs", NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowLogprobs { get; set; }

    [JsonProperty("allow_sampling", NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowSampling { get; set; }

    [JsonProperty("allow_search_indices", NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowSearchIndices { get; set; }

    [JsonProperty("allow_view", NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowView { get; set; }

    [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
    public long? Created { get; set; }

    [JsonProperty("group")]
    public object? Group { get; set; }

    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; }

    [JsonProperty("is_blocking", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsBlocking { get; set; }

    [JsonProperty("object?", NullValueHandling = NullValueHandling.Ignore)]
    public string? Object { get; set; }
    [JsonProperty("organization", NullValueHandling = NullValueHandling.Ignore)]
    public string? Organization { get; set; }

    #endregion Public Properties
}