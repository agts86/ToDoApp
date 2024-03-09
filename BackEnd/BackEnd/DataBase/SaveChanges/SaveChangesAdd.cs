using BackEnd.DataBase.Table;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.DataBase.SaveChanges;

public class SaveChangesAdd(EntityState entityState) : SaveChangesBase(entityState)
{
    public override void ChangeMeta(Meta meta)
    {
        meta.CreatedAt = DateTime.Now;
        meta.UpdatedAt = DateTime.Now;
    }
}
