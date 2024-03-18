using BackEnd.DataBase.Table;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using BackEnd.DataBase.SaveChanges;
namespace BackEnd.DataBase;

public class ToDoAppContext(DbContextOptions<ToDoAppContext> options) : DbContext(options)
{
    public virtual DbSet<ToDo> ToDos {get;set;}

    public virtual DbSet<Genre> Genres {get;set;}

    public virtual DbSet<Status> Statuses {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ToDo>(entity =>
        {
            entity.HasKey(e => new {e.Id});
        });
        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => new {e.Id});
        });
        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => new {e.Id});
        });
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries())
        {
            if (entry.Entity is not Meta meta) continue;

            var saveChanges = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => typeof(ISaveChanges).IsAssignableFrom(x) && !x.IsInterface)
                .Select(x => (ISaveChanges)Activator.CreateInstance(x,entry.State))
                .ToArray();
            foreach (var saveChange in saveChanges)
            {
                if(entry.State != saveChange.EntityState) continue;
                saveChange.ChangeMeta(meta);
            }

        }
        return base.SaveChangesAsync(cancellationToken);
    }
}

