namespace Candflow.Domain.Entities;

/// <summary>
/// Offer Status Entity.
/// </summary>
public sealed class OfferStatusEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Offers.
    /// </summary>
    public List<OfferEntity>? Offers { get; set; }
}
