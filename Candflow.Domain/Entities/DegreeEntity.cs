namespace Candflow.Domain.Entities;

/// <summary>
/// Degree Entity.
/// </summary>
public class DegreeEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Educations.
    /// </summary>
    public List<EducationEntity>? Educations { get; set; }
}
