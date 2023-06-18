namespace OpenAi.Api.Abstractions.Models.Edits;

public class EditRequest
{
    public EditRequest()
    {
    }

    /// <summary>
    /// Initializes a new instance of the CompletionRequest class with the specified model and prompt.
    /// </summary>
    /// <param name="model">The <see cref="Model"/> for the completion request.</param>
    /// <param name="instruction">The instructions for the edit request.</param>
    /// TODO: Revisit Models.Model namespace issue.
    public EditRequest(Models.Model model, string instruction)
    {
        if (string.IsNullOrEmpty(model.Id))
            throw new ArgumentNullException(nameof(model));

        Model = model.Id;
        Instruction = instruction;
    }

    /// <summary>
    /// Initializes a new instance of the CompletionRequest class with the specified model and prompt.
    /// </summary>
    /// <param name="model">The name of the model for the completion request.</param>
    /// <param name="instruction">The instructions for the edit request.</param>
    public EditRequest(string model, string instruction)
    {
        Model = model;
        Instruction = instruction;
    }

    public string Model { get; set; } = null!;

    public string? Input { get; set; } = string.Empty;

    public string Instruction { get; set; } = null!;
}