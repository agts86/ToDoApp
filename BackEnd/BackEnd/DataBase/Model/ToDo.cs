using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.DataBase.Model;

[Table("ToDo")]
public class ToDo
{
    [Key]
    [Column("Id")]
    public Guid Id { get; set; }

    [Column("Title")]
    [MaxLength(20)]
    public string Title { get; set; }

    [Column("GenreId")]
    public int GenreId { get; set; }

    [Column("Date")]
    public DateTime Date { get; set; }

    [Column("Content")]
    public string Content { get; set; }

    [Column("StatusId")]
    public int StatusId { get; set; }

    [ForeignKey(nameof(GenreId))]
    public Genre Genre { get; set; }

    [ForeignKey(nameof(StatusId))]
    public Status Status { get; set; }
}
