using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    public class MyDbContext : DbContext
    {
        public DbSet<Configuration> Configuration { get; set; }

        // private static DbContextOptionsBuilder optionsBuilder;

        // private MyDbContext(DbContextOptions options)
        //     : base(options)
        // {

        // }

        // public static void Initialize(string connectionString)
        // {
        //     optionsBuilder = new DbContextOptionsBuilder();
        //     optionsBuilder.UseNpgsql(connectionString, (opt) =>
        //     {

        //     });
        // }

        // public static MyDbContext Create()
        // {
        //     return new MyDbContext(optionsBuilder.Options);
        // }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./data.db");
        }
    }
}