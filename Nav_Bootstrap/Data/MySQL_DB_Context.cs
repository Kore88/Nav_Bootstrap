using Microsoft.EntityFrameworkCore;
using Nav_Bootstrap.Modell;

namespace Nav_Bootstrap.Data
{
    public class MySQL_DB_Context : DbContext
    {
        public MySQL_DB_Context(DbContextOptions<MySQL_DB_Context> options) : base(options){}
        public DbSet<PaciHotel> PaciHotel { get; set; } = default;
    }
     
}
