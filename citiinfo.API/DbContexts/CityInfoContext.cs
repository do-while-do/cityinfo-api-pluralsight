using Microsoft.EntityFrameworkCore;
using citiinfo.API.Entities;

namespace cityinfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {


        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        public CityInfoContext(DbContextOptions<CityInfoContext> options): base(options)
        {
        }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseNpgsql("conesdfsdfsdfsdf");
        //     base.OnConfiguring(optionsBuilder);
        // }
    }
}
