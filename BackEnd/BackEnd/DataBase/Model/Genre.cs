using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Model;

[Table("Genre")]
public class Genre
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }

    [Column("Value")]
    [MaxLength(10)]
    public string Value { get; set; }
}
