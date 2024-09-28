namespace Candflow.Domain.Entities;

/// <summary>
/// Interview Type Entity.
/// </summary>
public class InterviewTypeEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Interviews.
    /// </summary>
    public List<InterviewEntity>? Interviews { get; set; }
}
