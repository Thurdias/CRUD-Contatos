using Microsoft.EntityFrameworkCore;
using Sistema_De_Cadastro_De_Contatos.Models;

namespace Sistema_De_Cadastro_De_Contatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
