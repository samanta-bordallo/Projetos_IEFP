using Microsoft.EntityFrameworkCore;
using PotifolioSamanta.Models;

namespace PotifolioSamanta.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        public DbSet<ProjectsModel> Projects { get; set; }
    }
}
