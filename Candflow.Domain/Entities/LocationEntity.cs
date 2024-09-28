namespace Candflow.Domain.Entities;

/// <summary>
/// Location Entity.
/// </summary>
public sealed class LocationEntity : EntityBase
{
    /// <summary>
    /// Gets or sets City.
    /// </summary>
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Country.
    /// </summary>
    public string Country { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Positions.
    /// </summary>
    public List<PositionEntity>? Positions { get; set; }
}
