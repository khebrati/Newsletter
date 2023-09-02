using Microsoft.EntityFrameworkCore;
using Models;

namespace Data;
public class WeblogContext : DbContext
{
    public WeblogContext(DbContextOptions<WeblogContext> options) : base(options) {}
    public DbSet<Author> Authors {get ; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Article>().Property(e => e.Category).HasConversion<string>();
    }
}