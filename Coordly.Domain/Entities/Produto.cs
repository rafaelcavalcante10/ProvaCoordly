using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coordly.Domain.Entities
{
    public class Produto
    {
        [Key]
        [Column("ProductId")]
        public int codigo { get; set; }
        [Column("Name")]
        public string nome { get; set; }
        [Column("Price")]
        public double valor { get; set; }
        [Column("StockQuantity")]
        public int quantidade { get; set; }
    }
}
