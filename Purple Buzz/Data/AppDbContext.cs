using Microsoft.EntityFrameworkCore;
using Purple_Buzz.Entities;

namespace Purple_Buzz.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Service> Services { get; set; }
}
