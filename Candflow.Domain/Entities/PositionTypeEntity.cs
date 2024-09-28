namespace Candflow.Domain.Entities;

/// <summary>
/// Position Type Entity.
/// </summary>
public sealed class PositionTypeEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Positions.
    /// </summary>
    public List<PositionEntity>? Positions { get; set; }
}
