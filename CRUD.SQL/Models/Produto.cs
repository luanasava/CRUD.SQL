using OneOf.Types;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.SQL.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name ="Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Valor")]
        [Display(Name = "Valor")]
        public float Valor { get; set; }

        [Column("Estoque")]
        [Display(Name = "Estoque")]
        public int Estoque { get; set; }
    }
}
