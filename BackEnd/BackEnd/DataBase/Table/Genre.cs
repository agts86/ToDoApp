using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Table;

[Table("Genre")]
public class Genre : Meta
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Column("Value")]
    [Required]
    [MaxLength(10)]
    public string Value { get; set; }
}
