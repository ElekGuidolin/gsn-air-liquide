using Gsn.AirLiquide.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Gsn.AirLiquide.Web.Data
{
    public class GsnAirLiquideDbContext : DbContext
    {
        public GsnAirLiquideDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
