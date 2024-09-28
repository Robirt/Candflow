namespace Candflow.Domain.Entities;

/// <summary>
/// Application Status Entity.
/// </summary>
public sealed class ApplicationStatusEntity : EntityBase
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
