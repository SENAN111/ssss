using lumia.Models;
using Microsoft.EntityFrameworkCore;

namespace lumia.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Position>Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
