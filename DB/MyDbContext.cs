using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    public class MyDbContext : DbContext
    {
        public DbSet<Configuration> Configuration { get; set; }

        private MyDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public static MyDbContext Create()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=postgres;Database=test", (opt) => {
                
            });
            
            return new MyDbContext(optionsBuilder.Options);
        }
    }
}