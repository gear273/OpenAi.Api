using OpenAi.Api.Abstractions;
using System.Net.Http.Headers;

var apiKey = "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";
var apiKey2 = "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";

var httpClient = new HttpClient()
{
    BaseAddress = new Uri("https://api.openai.com/v1/"),
    DefaultRequestHeaders = {
        Authorization = new AuthenticationHeaderValue("Bearer", apiKey)
    }
};

var provider = new OpenAiApiProvider(httpClient);

var model = await provider.GetModelAsync("text-davinci-003");

Console.WriteLine("Finished.");