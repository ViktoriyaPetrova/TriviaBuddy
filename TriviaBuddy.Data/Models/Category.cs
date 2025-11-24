using System.ComponentModel.DataAnnotations;

namespace TriviaBuddy.Data.Models;

public class Category
{
    public Guid CategoryId { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    [MaxLength(512)]
    public string? Description { get; set; }
    public DateOnly CreatedOn { get; set; }
    public DateOnly ModifiedOn { get; set; }
    
    // Navigation properties
    public ICollection<Question> Questions { get; } = new List<Question>(); // N:N

}