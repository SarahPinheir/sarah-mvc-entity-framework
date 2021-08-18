using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sarah_mvs_entity.Models
{
  [Table("tb_cliente")]
  public class Cliente
  {
    [Key]
    [Column("cod")]
    public int Codigo { get;set; }

    [Column("nome", TypeName = "varchar")]
    [MaxLength(100)]
    [Required]
    public string Nome { get;set; }

    [Column("telefone", TypeName = "varchar")]
    [MaxLength(15)]
    public string Tel { get;set; }
    public ICollection<Pedido> Pedidos { get; set; }
  }
}