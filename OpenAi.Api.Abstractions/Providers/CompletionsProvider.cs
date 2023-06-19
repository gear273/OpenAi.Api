using Newtonsoft.Json;
using OpenAi.Api.Abstractions.Models.Completions;
using System.Text;
using OpenAi.Api.Abstractions.Models;

namespace OpenAi.Api.Abstractions.Providers;

public class CompletionsProvider
{
    private readonly HttpClient _httpClient;

    public CompletionsProvider(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Asynchronously generates a completion based on the provided <see cref="Response"/>.
    /// </summary>
    /// <param name="completionRequest">The completion request object.</param>
    /// <returns>A <see cref="Task{string}"/> representing the asynchronous operation. The task result contains the generated completion as a JSON string, or <c>null</c> if an error occurs.</returns>
    public async Task<Response?> GetAsync(CompletionRequest completionRequest)
    {
        try
        {
            var request = new StringContent(JsonConvert.SerializeObject(completionRequest), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("completions", request);

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Response>(json);
        }
        catch
        {
            return null;
        }
    }
}