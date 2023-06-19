using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using OpenAi.Api.Abstractions.Providers;

namespace OpenAi.Api.Abstractions;

/// <summary>
/// Represents a provider for interacting with the OpenAI API.
/// </summary>
public class OpenAiApi
{
    #region Public Properties

    public string BaseUri { get; set; } = "https://api.openai.com/v1/";
    public CompletionsProvider Completions { get; private set; }

    #endregion Public Properties

    #region Public Constructors

    public OpenAiApi(string apiKey)
    {
        var httpClient = new HttpClient()
        {
            BaseAddress = new Uri(BaseUri),
            DefaultRequestHeaders = { Authorization = new AuthenticationHeaderValue("Bearer", apiKey) }
        };

        Completions = new CompletionsProvider(httpClient);
    }

    public OpenAiApi(HttpClient httpClient)
    {
        Completions = new CompletionsProvider(httpClient);
    }

    #endregion Public Constructors
}