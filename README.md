# OpenAi.Api

The `OpenAiProvider` class is a provider for interacting with the OpenAI API. It allows you to generate completions and retrieve information about specific models.

## Public Constructors

### OpenAiProvider(HttpClient httpClient)
Initializes a new instance of the `OpenAiProvider` class with the specified `HttpClient` object used for making HTTP requests to the OpenAI API.

- `httpClient`: The `HttpClient` object to use for making HTTP requests.

## Public Methods

### Task<string?> GenerateCompletionAsync(CompletionRequest completionRequest)
Asynchronously generates a completion based on the provided `CompletionRequest`.

- `completionRequest`: The completion request object.
- Returns: A `Task<string>` representing the asynchronous operation. The task result contains the generated completion as a JSON string, or `null` if an error occurs.

### Task<Model?> GetModelAsync(string modelName)
Asynchronously retrieves information about a specific model by its name.

- `modelName`: The name of the model.
- Returns: A `Task<Model>` representing the asynchronous operation. The task result contains the retrieved model information as a `Model` object, or `null` if an error occurs.

## Usage

To use the `OpenAiProvider` class, you need to instantiate it with an `HttpClient` object and then call the desired methods. Here's an example:

```csharp
HttpClient httpClient = new HttpClient();
OpenAiProvider openAiProvider = new OpenAiProvider(httpClient);

// Generate completion
CompletionRequest completionRequest = new CompletionRequest(model, prompt);
string? completion = await openAiProvider.GenerateCompletionAsync(completionRequest);

// Get model information
string modelName = "davinci-codex";
Model? model = await openAiProvider.GetModelAsync(modelName);
