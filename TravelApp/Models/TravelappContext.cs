using Microsoft.EntityFrameworkCore;

namespace TravelappItem.Models;
public class TravelappContex : DbContext
{
    public TravelappContex(DbContextOption<TravelappContex> options) : base(options)
    {

    }
    public DbSet<TravelappItem> TodoItems { get; set; } = null;
}

