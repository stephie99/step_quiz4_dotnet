using Microsoft.EntityFrameworkCore;

namespace ssantos_quiz4.Db;

public class AppDbContext : DbContext
{
    //public DbSet<YourModel> YourModels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("YourConnectionString");
    }
}