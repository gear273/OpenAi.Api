using System.Text;
using Newtonsoft.Json;
using OpenAi.Api.Abstractions.Models;

namespace OpenAi.Api.Abstractions
{
    /// <summary>
    /// Represents a provider for interacting with the OpenAI API.
    /// </summary>
    public class OpenAiProvider
    {
        #region Private Fields

        private readonly HttpClient _httpClient;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiProvider"/> class with the specified <see cref="HttpClient"/> object used for making HTTP requests to the OpenAI API.
        /// </summary>
        /// <param name="httpClient">The <see cref="HttpClient"/> object to use for making HTTP requests.</param>
        public OpenAiProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Asynchronously generates a completion based on the provided <see cref="CompletionRequest"/>.
        /// </summary>
        /// <param name="completionRequest">The completion request object.</param>
        /// <returns>A <see cref="Task{string}"/> representing the asynchronous operation. The task result contains the generated completion as a JSON string, or <c>null</c> if an error occurs.</returns>
        public async Task<string?> GenerateCompletionAsync(CompletionRequest completionRequest)
        {
            try
            {
                var request = new StringContent(JsonConvert.SerializeObject(completionRequest), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("https://api.openai.com/v1/engines/davinci-codex/completions", request);

                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                return json;
            }
            catch
            {
                return default;
            }
        }

        /// <summary>
        /// Asynchronously retrieves information about a specific model by its name.
        /// </summary>
        /// <param name="modelName">The name of the model.</param>
        /// <returns>A <see cref="Task{Model}"/> representing the asynchronous operation. The task result contains the retrieved model information as a <see cref="Model"/> object, or <c>null</c> if an error occurs.</returns>
        public async Task<Model?> GetModelAsync(string modelName)
        {
            try
            {
                var response = await _httpClient.GetAsync($"models/{modelName}");

                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();

                var model = JsonConvert.DeserializeObject<Model>(json);

                return model;
            }
            catch
            {
                return null;
            }
        }

        #endregion Public Methods
    }
}
