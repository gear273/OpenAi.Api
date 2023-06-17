using Newtonsoft.Json;

namespace OpenAi.Api.Abstractions.Models;

/// <summary>
/// Represents a completion request for an AI model.
/// </summary>
public class CompletionRequest
{
    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the CompletionRequest class with the specified model and prompt.
    /// </summary>
    /// <param name="model">The <see cref="Model"/> for the completion request.</param>
    /// <param name="prompt">The prompt text for the completion request.</param>
    public CompletionRequest(Model model, string prompt)
    {
        if (string.IsNullOrEmpty(model.Id))
            throw new ArgumentNullException(nameof(model));

        Model = model.Id;
        Prompt = prompt;
    }

    /// <summary>
    /// Initializes a new instance of the CompletionRequest class with the specified model and prompt.
    /// </summary>
    /// <param name="model">The name of the model for the completion request.</param>
    /// <param name="prompt">The prompt text for the completion request.</param>
    public CompletionRequest(string model, string prompt)
    {
        Model = model;
        Prompt = prompt;
    }

    #endregion Public Constructors

    #region Public Properties

    /// <summary>
    /// Gets or sets the number of candidates to sample and rank in the completion generation.
    /// </summary>
    [JsonProperty("best_of")]
    public int? BestOf { get; set; } = 1;

    /// <summary>
    /// Gets or sets a value indicating whether to include the prompt in the completion response.
    /// </summary>
    [JsonProperty("echo")]
    public bool Echo { get; set; } = false;

    /// <summary>
    /// Gets or sets the frequency penalty value for discouraging the model from generating repetitive completions.
    /// </summary>
    [JsonProperty("frequency_penalty")]
    public double FrequencyPenalty { get; set; } = 0;

    /// <summary>
    /// Gets or sets a dictionary representing the logit bias to influence the model's output probabilities.
    /// </summary>
    [JsonProperty("logit_bias")]
    public Dictionary<int, double>? LogitBias { get; set; }

    /// <summary>
    /// Gets or sets the number of log probabilities to include in the completion response.
    /// </summary>
    [JsonProperty("logprobs")]
    public int? LogProbs { get; set; }

    /// <summary>
    /// Gets or sets the maximum number of tokens to generate in the completion response.
    /// </summary>
    [JsonProperty("max_tokens")]
    public int? MaxTokens { get; set; } = 16;

    /// <summary>
    /// Gets or sets the model to use for the completion request.
    /// </summary>
    [JsonProperty("model")]
    public string Model { get; set; }

    /// <summary>
    /// Gets or sets the number of completions to generate.
    /// </summary>
    [JsonProperty("n")]
    public int N { get; set; } = 1;

    /// <summary>
    /// Gets or sets the presence penalty value for encouraging the model to be more cautious in generating repetitive completions.
    /// </summary>
    [JsonProperty("presence_penalty")]
    public double PresencePenalty { get; set; } = 0;

    /// <summary>
    /// Gets or sets the prompt text for the completion request.
    /// </summary>
    [JsonProperty("prompt")]
    public string Prompt { get; set; }

    /// <summary>
    /// Gets or sets a list of strings that serve as stopping conditions for the completion generation.
    /// </summary>
    [JsonProperty("stop")]
    public List<string>? Stop { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the completions should be streamed as they become available.
    /// </summary>
    [JsonProperty("stream")]
    public bool Stream { get; set; } = false;

    /// <summary>
    /// Gets or sets an optional suffix to append to the completion result.
    /// </summary>
    [JsonProperty("suffix")]
    public string? Suffix { get; set; }
    /// <summary>
    /// Gets or sets the temperature value for randomness in the completion generation.
    /// </summary>
    [JsonProperty("temperature")]
    public double Temperature { get; set; } = 1;

    /// <summary>
    /// Gets or sets the top-p value for nucleus sampling in the completion generation.
    /// </summary>
    [JsonProperty("top_p")]
    public double TopP { get; set; } = 1;
    /// <summary>
    /// Gets or sets the user identifier associated with the completion request.
    /// </summary>
    [JsonProperty("user")]
    public string? User { get; set; }

    #endregion Public Properties
}