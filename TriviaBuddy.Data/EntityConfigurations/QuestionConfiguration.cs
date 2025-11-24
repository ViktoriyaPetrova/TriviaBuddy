using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TriviaBuddy.Data.Models;

namespace TriviaBuddy.Data.EntityConfigurations;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>

{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        // Make sure all columns have correct names
        builder.Property(x => x.QuestionId)
            .HasColumnName("question_id");
        builder.Property(x => x.QuestionText)
            .HasColumnName("question_text");
        builder.Property(x => x.QuestionType)
            .HasColumnName("question_type");
        builder.Property(x => x.QuestionMediaType)
            .HasColumnName("question_media_type");
        builder.Property(x => x.Difficulty)
            .HasColumnName("difficulty");
        builder.Property(x => x.MediaUrl)
            .HasColumnName("media_url");
        builder.Property(x => x.CreatedOn)
            .HasColumnName("created_on");
        builder.Property(x =>x.ModifiedOn)
            .HasColumnName("modified_on");
        
        // Set default values
        builder.Property(x => x.QuestionId)
            .HasDefaultValueSql("uuid_generate_v4()");
        builder.Property(x => x.CreatedOn)
            .HasDefaultValueSql("CURRENT_DATE");
        builder.Property(x => x.ModifiedOn)
            .HasDefaultValueSql("CURRENT_DATE");
        
    }
}