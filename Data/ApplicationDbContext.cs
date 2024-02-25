using EmpreatimoLivro.Models;
using Microsoft.EntityFrameworkCore;

namespace EmpreatimoLivro.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<EmprestimoModels> Emprestimos { get; set; }
    }
}
