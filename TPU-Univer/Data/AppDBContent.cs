
using Microsoft.EntityFrameworkCore;
using TPU_Univer.Data.Models;

namespace TPU_Univer.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {

        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
