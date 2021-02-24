using Microsoft.EntityFrameworkCore;


public class ExceptionsDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("DataBase=Exceptions.db");

}

