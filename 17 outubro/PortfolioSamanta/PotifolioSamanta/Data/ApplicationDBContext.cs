using Microsoft.EntityFrameworkCore;
using PortfolioSamanta.Models;
using PotifolioSamanta.Models;

namespace PotifolioSamanta.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<ProjectsModel> Projects { get; set; }
        public DbSet<AboutMeModel> AboutMe { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutMeModel>().HasNoKey();
        }
    }
}
