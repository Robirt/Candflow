namespace Candflow.Domain.Entities;

/// <summary>
/// Candidate Entity.
/// </summary>
public sealed class CandidateEntity : EntityBase
{
    /// <summary>
    /// Gets or sets First Name.
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Last Name.
    /// </summary>
    public string LastName { get; set; } = string.Empty;

    /// <summary>
    /// Gets Full Name.
    /// </summary>
    public string FullName => $"{FirstName} {LastName}";

    /// <summary>
    /// Gets or sets Gender Id.
    /// </summary>
    public int GenderId { get; set; }

    /// <summary>
    /// Gets or sets Gender.
    /// </summary>
    public GenderEntity Gender { get; set; } = new GenderEntity();

    /// <summary>
    /// Gets or sets Birth Date.
    /// </summary>
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Gets or sets Email.
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets Phone Number.
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets Residence.
    /// </summary>
    public string? Residence { get; set; }

    /// <summary>
    /// Gets or sets Notes.
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Gets or sets LinkedIn Url.
    /// </summary>
    public string? LinkedInUrl { get; set; }

    /// <summary>
    /// Gets or sets Applications.
    /// </summary>
    public List<ApplicationEntity> Applications { get; set; } = new List<ApplicationEntity>();
}
