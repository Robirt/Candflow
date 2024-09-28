namespace Candflow.Domain.Entities;

/// <summary>
/// Offer Entity.
/// </summary>
public sealed class OfferEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Salary.
    /// </summary>
    public int Salary { get; set; }

    /// <summary>
    /// Gets or sets Start Date.
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets Notes.
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Gets or sets Created At.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets or sets Application Id.
    /// </summary>
    public int ApplicationId { get; set; }

    /// <summary>
    /// Gets or sets Application.
    /// </summary>
    public ApplicationEntity Application { get; set; } = new ApplicationEntity();

    /// <summary>
    /// Gets or sets Offer Status Id.
    /// </summary>
    public int OfferStatusId { get; set; }

    /// <summary>
    /// Gets or sets Offer Status.
    /// </summary>
    public OfferStatusEntity OfferStatus { get; set; } = new OfferStatusEntity();
}
