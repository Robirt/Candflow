namespace Candflow.Domain.Entities;

/// <summary>
/// Document Entity.
/// </summary>
public sealed class DocumentEntity : EntityBase
{
    /// <summary>
    /// Gets or sets Name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Url.
    /// </summary>
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Uploaded At.
    /// </summary>
    public DateTime UploadedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets or sets Application Id.
    /// </summary>
    public int ApplicationId { get; set; }

    /// <summary>
    /// Gets or sets Application.
    /// </summary>
    public ApplicationEntity Application { get; set; } = new ApplicationEntity();
}
