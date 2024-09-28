namespace Candflow.Domain.Entities;

/// <summary>
/// Interview Entity.
/// </summary>
public sealed class InterviewEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Date.
    /// </summary>
    public DateTime Date { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets or sets Interview Type Id.
    /// </summary>
    public int InterviewTypeId { get; set; }

    /// <summary>
    /// Gets or sets Type.
    /// </summary>
    public InterviewTypeEntity Type { get; set; } = new InterviewTypeEntity();

    /// <summary>
    /// Gets or sets Application Id.
    /// </summary>
    public int ApplicationId { get; set; }

    /// <summary>
    /// Gets or sets Application.
    /// </summary>
    public ApplicationEntity Application { get; set; } = new ApplicationEntity();

    /// <summary>
    /// Gets or sets Recruiter Id.
    /// </summary>
    public string RecruiterId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Feedbacks.
    /// </summary>
    public List<FeedbackEntity>? Feedbacks { get; set; }
}
