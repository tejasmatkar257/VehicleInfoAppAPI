using Microsoft.EntityFrameworkCore;
using Vehicle_Info_APP.Models;

namespace Vehicle_Info_APP.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
