using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sarah_mvs_entity.Models
{
  [Table("pedidos")]
  public class Pedido
  {
    [Key]
    public int Id { get;set; }

    [Column("cliente_id")]
    [Required]
    [ForeignKey("ClienteId")]
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }

    [Column("valor_total")]
    [Required]
    public double ValorTotal { get;set; }

    [Column("data_do_pedido")]
    [Required]
    public DateTime Data { get;set; }
  }
}
