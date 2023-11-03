using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PotifolioSamanta.Models;

namespace PotifolioSamanta.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<ProjectsModel> Projects { get; set; }
        public DbSet<AboutMeModel> AboutMe { get; set; }


       // protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {
       //     modelBuilder.Entity<AboutMeModel>().HasNoKey();
       //}
    }
}
