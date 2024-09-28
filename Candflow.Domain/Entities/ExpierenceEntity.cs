namespace Candflow.Domain.Entities;

/// <summary>
/// Expierence Entity.
/// </summary>
public sealed class ExpierenceEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Company.
    /// </summary>
    public string Company { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Position.
    /// </summary>
    public string Position { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Start Date.
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Gets or sets End Date.
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Gets or sets Description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets Application Id.
    /// </summary>
    public int ApplicationId { get; set; }

    /// <summary>
    /// Gets or sets Application.
    /// </summary>
    public ApplicationEntity Application { get; set; } = new ApplicationEntity();
}
