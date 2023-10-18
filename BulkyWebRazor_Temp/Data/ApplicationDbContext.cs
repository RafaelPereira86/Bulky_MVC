using Microsoft.EntityFrameworkCore;
using BulkyWebRazor_Temp.Models;

namespace BulkyWebRazor_Temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { ID = 1, DisplayOrder = 1, Name = "Action" },
                new Category { ID = 2, DisplayOrder = 2, Name = "SciFi" },
                new Category { ID = 3, DisplayOrder = 3, Name = "History" }
                );
        }
    }
}
