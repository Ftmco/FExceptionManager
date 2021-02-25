using Microsoft.EntityFrameworkCore;


/// <summary>
/// Data Base Context
/// </summary>
public class ExceptionsDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("DataBase=Exceptions.db");

    public DbSet<Exceptions> Exceptions { get; set; }

}

