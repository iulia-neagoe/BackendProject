using Microsoft.EntityFrameworkCore;

namespace TravelApp.Models;
public class TravelappContext : DbContext
{
    public TravelappContext(DbContextOption<TravelappContext> options) : base(options)
    {

    }
    public DbSet<TravelappItem> TodoItems { get; set; } = null;
}

