using TriviaBuddy.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TriviaBuddy.Data.Factories;

public class TriviaBuddyContextFactory : IDesignTimeDbContextFactory<TriviaBuddyContext>
{
    public TriviaBuddyContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "TriviaBuddy.Api")))
            .AddJsonFile("appsettings.json")
            .Build();
        var connectionString = configuration.GetConnectionString("TriviaBuddyConnectionString");
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ArgumentException("Trivia Buddy connection string is missing");
        }
        var optionsBuilder = new DbContextOptionsBuilder<TriviaBuddyContext>();
        optionsBuilder.UseNpgsql(connectionString, npOptions => npOptions.MigrationsHistoryTable("__EFMigrationsHistory", "TriviaBuddy"));
        
        return new TriviaBuddyContext(optionsBuilder.Options);
    }
}