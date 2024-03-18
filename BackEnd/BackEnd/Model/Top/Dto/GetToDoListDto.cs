
namespace BackEnd.Model.Top.Dto;

public class GetToDoListDto
{
    public string Title { get; set; }

    public int? Genre { get; set; }

    public DateTime? Date { get; set; }

    public int? Status { get; set; }
}
