using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Paper> Papers { get; set; }
    public DbSet<Question> Questions { get; set; }
}

public class Paper
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Subject { get; set; }
}

public class Question
{
    public int Id { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
}
