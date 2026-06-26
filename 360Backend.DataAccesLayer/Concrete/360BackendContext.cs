using _360Backend.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace _360Backend.DataAccesLayer.Concrete;

public class _360BackendContext : DbContext
{
    public _360BackendContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Aboutus> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<MainPage> MainPages { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Review> reviews { get; set; }
}
