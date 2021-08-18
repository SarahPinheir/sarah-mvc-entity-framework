  
using sarah_mvs_entity.Models;
using Microsoft.EntityFrameworkCore;

namespace sarah_mvs_entity.Servicos
{
  public class DbContexto : DbContext
  {
    public DbContexto(DbContextOptions<DbContexto> options) : base(options) { }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
  }
}