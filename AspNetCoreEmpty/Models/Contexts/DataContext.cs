using AspNetCoreEmpty.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEmpty.Models.Contexts
{
    public class DataContext :  DbContext

    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    string cString = "Server=LAPTOP-6I4SKCDS;Database=P237;User Id=sa;Password=query;MultipleActiveResultSets=true;";
        //    optionsBuilder.UseSqlServer(cString);   
        //}

        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
