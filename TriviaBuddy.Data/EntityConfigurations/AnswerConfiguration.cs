using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TriviaBuddy.Data.Models;

namespace TriviaBuddy.Data.EntityConfigurations;

internal class AnswerConfiguration : IEntityTypeConfiguration<Answer>
{
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        // Make sure all columns have correct names
        builder.Property(x => x.AnswerId)
            .HasColumnName("answer_id");
        builder.Property(x => x.QuestionId)
            .HasColumnName("question_id");
        builder.Property(x => x.AnswerText)
            .HasColumnName("answer_text");
        builder.Property(x => x.IsCorrect)
            .HasColumnName("is_correct");
        builder.Property(x => x.CreatedOn)
            .HasColumnName("created_on");
        builder.Property(x =>x.ModifiedOn)
            .HasColumnName("modified_on");
        
        // Set default values
        builder.Property(x => x.AnswerId)
            .HasDefaultValueSql("uuid_generate_v4()");
        builder.Property(x => x.CreatedOn)
            .HasDefaultValueSql("CURRENT_DATE");
        builder.Property(x => x.ModifiedOn)
            .HasDefaultValueSql("CURRENT_DATE");
        
    }
}