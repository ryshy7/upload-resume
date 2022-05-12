using System.ComponentModel.DataAnnotations;

namespace ResumeWebApi;

public class Resume
{
    [Required]
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    [Required]
    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    [Required]
    public bool LiveInUS { get; set; }

    [Required]
    public string? GitProfile { get; set; }

    [Required]
    public string? CV { get; set; }

    public string? CoverLetter { get; set; }

    [Required]
    public string? AboutYou { get; set; }
}