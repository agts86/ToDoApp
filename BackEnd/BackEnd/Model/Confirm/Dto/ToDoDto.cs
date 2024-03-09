

using System.ComponentModel.DataAnnotations;

namespace BackEnd.Model.Confirm.Dto;

public class ToDoDto()
{
    [Required]
    [MaxLength(20)]
    public string Title { get; set; }

    public int Genre { get; set; }

    public DateTime Date { get; set; }

    [Required]
    public string Content { get; set; }

    public int Status { get; set; }
}
