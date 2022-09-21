using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace ListTask.Models 
{
    public class ListContext : DbContext
    {
        public ListContext(DbContextOptions<ListContext> options)
            : base(options)
        {
        }

        public DbSet<Listtask> Listtask { get; set; } = null!;
    }
}
