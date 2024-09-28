namespace Candflow.Domain.Entities;

/// <summary>
/// Application Entity.
/// </summary>
public sealed class ApplicationEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Applied At.
    /// </summary>
    public DateTime AppliedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets or sets Portfolio Url.
    /// </summary>
    public string? PortfolioUrl { get; set; }

    /// <summary>
    /// Gets or sets Position Id.
    /// </summary>
    public int PositionId { get; set; }

    /// <summary>
    /// Gets or sets Position.
    /// </summary>
    public PositionEntity Position { get; set; } = new PositionEntity();

    /// <summary>
    /// Gets or sets Candidate Id.
    /// </summary>
    public int CandidateId { get; set; }

    /// <summary>
    /// Gets or sets Candidate.
    /// </summary>
    public CandidateEntity Candidate { get; set; } = new CandidateEntity();

    /// <summary>
    /// Gets or sets Status Id.
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    /// Gets or sets Status.
    /// </summary>
    public ApplicationStatusEntity Status { get; set; } = new ApplicationStatusEntity();

    /// <summary>
    /// Gets or sets Educations.
    /// </summary>
    public List<EducationEntity> Educations { get; set; } = new List<EducationEntity>();

    /// <summary>
    /// Gets or sets Expierences.
    /// </summary>
    public List<ExpierenceEntity> Expierences { get; set; } = new List<ExpierenceEntity>();

    /// <summary>
    /// Gets or sets Skills.
    /// </summary>
    public List<SkillEntity> Skills { get; set; } = new List<SkillEntity>();

    /// <summary>
    /// Gets or sets Documents.
    /// </summary>
    public List<DocumentEntity>? Documents { get; set; }

    /// <summary>
    /// Gets or sets Offers.
    /// </summary>
    public List<OfferEntity>? Offers { get; set; }
}
