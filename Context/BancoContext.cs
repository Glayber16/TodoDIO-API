using Microsoft.EntityFrameworkCore;
using TodoDIO.Models;

namespace TodoDIO.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
            
        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
