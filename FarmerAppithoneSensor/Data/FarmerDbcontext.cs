using FarmerAppithoneSensor.Models;
using Microsoft.EntityFrameworkCore;

namespace FarmerAppithoneSensor.Data
{
	public class FarmerDbcontext : DbContext
	{
        public FarmerDbcontext(DbContextOptions options ) : base (options)
        {
            
        }

        public DbSet<Tempreture> tempretures { get; set; }

    }
}
