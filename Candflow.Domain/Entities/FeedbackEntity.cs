namespace Candflow.Domain.Entities;

/// <summary>
/// Feedback Entity.
/// </summary>
public sealed class FeedbackEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Content.
    /// </summary>
    public string Content { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets value indicating whether Is Positive.
    /// </summary>
    public bool IsPositive { get; set; } = false;

    /// <summary>
    /// Gets or sets Interview Id.
    /// </summary>
    public int InterviewId { get; set; }

    /// <summary>
    /// Gets or sets Interview.
    /// </summary>
    public InterviewEntity Interview { get; set; } = new InterviewEntity();

    /// <summary>
    /// Gets or sets Recruiter Id.
    /// </summary>
    public string RecruiterId { get; set; } = string.Empty;
}
