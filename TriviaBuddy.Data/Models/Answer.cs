using System.ComponentModel.DataAnnotations;

namespace TriviaBuddy.Data.Models;

public class Answer
{
    public Guid AnswerId { get; set; }
    public Guid QuestionId { get; set; }
    [Required]
    [MaxLength(256)]
    public string AnswerText { get; set; } = null!;
    public bool IsCorrect { get; set; }
    public DateOnly CreatedOn { get; set; }
    public DateOnly ModifiedOn { get; set; }
    
    // Navigation properties
    public Question Question { get; set; } = null!; // N:1
}