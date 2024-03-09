using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Table;

public abstract class Meta
{
    [Column("CreatedAt")]
    public DateTime CreatedAt { get; set; }

    [Column("UpdatedAt")]
    public DateTime UpdatedAt { get; set; }
}
