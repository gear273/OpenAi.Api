using System.Text;
using Newtonsoft.Json;
using OpenAiCompletion.Models;

namespace OpenAiCompletion;

/// <summary>
/// Provides a method to generate completions using an HTTP client.
/// </summary>
public class CompletionProvider
{
    private readonly HttpClient _client;

    /// <summary>
    /// Initializes a new instance of the CompletionProvider class with the specified HTTP client.
    /// </summary>
    /// <param name="client">The HttpClient used for making API requests.</param>
    public CompletionProvider(HttpClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Generates a completion asynchronously using the specified completion request.
    /// </summary>
    /// <param name="completionRequest">The CompletionRequest object containing the completion parameters.</param>
    /// <returns>A string representing the generated completion response in JSON format.</returns>
    public async Task<string?> GenerateCompletionAsync(CompletionRequest completionRequest)
    {
        try
        {
            var request = new StringContent(JsonConvert.SerializeObject(completionRequest), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://api.openai.com/v1/engines/davinci-codex/completions", request);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return json;
        }
        catch
        {
            return default;
        }
    }
}