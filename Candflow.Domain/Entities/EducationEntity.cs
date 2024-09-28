namespace Candflow.Domain.Entities;

/// <summary>
/// Education Entity.
/// </summary>
public sealed class EducationEntity : EntityBase
{
    /// <summary>
    /// Gets or sets School.
    /// </summary>
    public string School { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Field.
    /// </summary>
    public string Field { get; set; } = string.Empty;

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
    /// Gets or sets Degree Id.
    /// </summary>
    public int DegreeId { get; set; }

    /// <summary>
    /// Gets or sets Degree.
    /// </summary>
    public DegreeEntity Degree { get; set; } = new DegreeEntity();

    /// <summary>
    /// Gets or sets Application Id.
    /// </summary>
    public int ApplicationId { get; set; }

    /// <summary>
    /// Gets or sets Application.
    /// </summary>
    public ApplicationEntity Application { get; set; } = new ApplicationEntity();
}
