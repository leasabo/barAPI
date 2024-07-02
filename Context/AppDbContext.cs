using barAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace barAPI.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }


        public DbSet<Table> Tables { get; set; }
    }
}
