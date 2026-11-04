using System.ComponentModel.DataAnnotations;

namespace SkillingAPI.Models;

public class Course
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; } = string.Empty;

    [Range(0.01, double.MaxValue)]
    public double DurationHours { get; set; }

    public bool IsPublished { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}