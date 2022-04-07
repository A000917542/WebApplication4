using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class MemoryDbContext : DbContext
    {
        public MemoryDbContext(DbContextOptions<MemoryDbContext> options)
            : base(options)
        { }

        public DbSet<SimpleModel> SimpleModel { get; set; }
    }
}
