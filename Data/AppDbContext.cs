using Microsoft.EntityFrameworkCore;
using Npgsql.efcore.pg.issue1576repro.Entities;

namespace Npgsql.efcore.pg.issue1576repro.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(nameof(issue1576repro));
        }

        public DbSet<Todo> Tasks { get; set; }
    }
}