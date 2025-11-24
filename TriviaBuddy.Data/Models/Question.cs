using System.ComponentModel.DataAnnotations;
using TriviaBuddy.Data.Enums;

namespace TriviaBuddy.Data.Models;

public class Question
{
    public Guid QuestionId { get; set; }
    [Required]
    [MaxLength(1024)]
    public string QuestionText { get; set; } = null!;
    public QuestionType QuestionType { get; set; } = QuestionType.SingleAnswer;
    public QuestionMediaType QuestionMediaType { get; set; } = QuestionMediaType.Text;
    public Difficulty Difficulty { get; set; } = Difficulty.Medium;
    public string? MediaUrl { get; set; }
    public DateOnly CreatedOn { get; set; }
    public DateOnly ModifiedOn { get; set; }  
    
    // Navigation properties
    public ICollection<Answer> Answers { get; } = []; // 1:N
    public ICollection<Category> Categories { get; } = []; // N:N
}