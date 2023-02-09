using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

public partial class MariaDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public MariaDbContext(DbContextOptions<MariaDbContext> options)
        : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}


