using BackEnd.DataBase.Model;
using Microsoft.EntityFrameworkCore;

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
}

