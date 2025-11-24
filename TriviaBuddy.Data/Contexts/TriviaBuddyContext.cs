using Microsoft.EntityFrameworkCore;
using TriviaBuddy.Data.Enums;
using TriviaBuddy.Data.Models;

namespace TriviaBuddy.Data.Contexts;

public class TriviaBuddyContext: DbContext
{
    public TriviaBuddyContext(DbContextOptions<TriviaBuddyContext> options): base(options)
    {
    }
    
    public DbSet<Category> Categories { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("TriviaBuddy");
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TriviaBuddyContext).Assembly);
        
        modelBuilder.HasPostgresExtension("uuid-ossp");
        
        base.OnModelCreating(modelBuilder);
    }
}