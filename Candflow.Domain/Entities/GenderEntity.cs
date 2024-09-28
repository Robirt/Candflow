namespace Candflow.Domain.Entities;

/// <summary>
/// Gender Entity.
/// </summary>
public sealed class GenderEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Candidates.
    /// </summary>
    public List<CandidateEntity>? Candidates { get; set; }
}
