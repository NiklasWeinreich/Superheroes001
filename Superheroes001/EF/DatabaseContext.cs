
namespace Superheroes001.EF;

public class DatabaseContext : DbContext
{
    // this can be used in several ways
    // 1) connection directly from here
    // 2) connection in configuration file
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }


    // tables in DB
    public DbSet<Hero> Hero { get; set; }

    public DbSet<Superman> Superman { get; set; }

}
