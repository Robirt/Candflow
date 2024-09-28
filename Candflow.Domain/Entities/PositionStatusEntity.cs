namespace Candflow.Domain.Entities;

/// <summary>
/// Position Status Entity.
/// </summary>
public sealed class PositionStatusEntity : EntityBase
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