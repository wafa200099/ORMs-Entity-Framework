using Microsoft.EntityFrameworkCore;
using PublisherDomain;



namespace PublisherData;

public class PubContext : DbContext
{
    public DbSet<Auther> Authers { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=PubDatabase").LogTo(Console.WriteLine);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Auther>().HasData(new Auther {Id=1, FirstName = "awafa", LastName = "mh" });
    }
}