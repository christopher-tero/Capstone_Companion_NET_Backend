using CapstoneCompanion.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CapstoneCompanion.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Resource> Resources { get; set; }
    }
}