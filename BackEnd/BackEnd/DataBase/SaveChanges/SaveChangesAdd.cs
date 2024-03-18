using BackEnd.DataBase.Table;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.SaveChanges;

public class SaveChangesAdd : ISaveChanges
{
    public EntityState EntityState { get; set; } = EntityState.Added;
    public void ChangeMeta(Meta meta)
    {
        meta.CreatedAt = DateTime.Now;
        meta.UpdatedAt = DateTime.Now;
    }
}
