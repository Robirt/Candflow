namespace Candflow.Domain.Entities;

/// <summary>
/// Skill Entity.
/// </summary>
public sealed class SkillEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Applications.
    /// </summary>
    public List<ApplicationEntity>? Applications { get; set; }
}
