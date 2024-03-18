using BackEnd.DataBase.Table;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.SaveChanges;

public class SaveChangesModify: ISaveChanges
{
    public EntityState EntityState { get; set; } = EntityState.Modified;
    public void ChangeMeta(Meta meta)
    {
        meta.CreatedAt = DateTime.Now;
        meta.UpdatedAt = DateTime.Now;
    }
}
