using Microsoft.EntityFrameworkCore;
using JogosEmprestimosAula.Models;

namespace JogosEmprestimosAula.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) :base(options) { }
        public DbSet<EmprestimosModel> Emprestimos { get; set; }    
    }
}

