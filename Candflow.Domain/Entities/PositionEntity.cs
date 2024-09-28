namespace Candflow.Domain.Entities;

/// <summary>
/// Position Entity.
/// </summary>
public sealed class PositionEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Position Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Position Description.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Status Id.
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    /// Gets or sets Status.
    /// </summary>
    public PositionStatusEntity Status { get; set; } = new PositionStatusEntity();

    /// <summary>
    /// Gets or sets Position Level Id.
    /// </summary>
    public int PositionLevelId { get; set; }

    /// <summary>
    /// Gets or sets Position Level.
    /// </summary>
    public PositionLevelEntity PositionLevel { get; set; } = new PositionLevelEntity();

    /// <summary>
    /// Gets or sets Type Id.
    /// </summary>
    public int TypeId { get; set; }

    /// <summary>
    /// Gets or sets Type.
    /// </summary>
    public PositionTypeEntity Type { get; set; } = new PositionTypeEntity();

    /// <summary>
    /// Gets or sets Minimum Salary.
    /// </summary>
    public int? MinimumSalary { get; set; }

    /// <summary>
    /// Gets or sets Maximum Salary.
    /// </summary>
    public int? MaximumSalary { get; set; }

    /// <summary>
    /// Gets or sets Start Date.
    /// </summary>
    public DateTime StartDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets or sets End Date.
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// Gets or sets Created At.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets or sets Recruiter Id.
    /// </summary>
    public string RecruiterId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Position Applications.
    /// </summary>
    public List<ApplicationEntity> Applications { get; set; } = new List<ApplicationEntity>();
}
