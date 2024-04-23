using Microsoft.EntityFrameworkCore;
using ProjetoEstoquePromissoria.Models;

namespace ProjetoEstoquePromissoria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //Criando tabela e referenciando o DbContext e inserindo dados

        public DbSet<PromissoriasModel> Promissorias { get; set; }
    }
}
