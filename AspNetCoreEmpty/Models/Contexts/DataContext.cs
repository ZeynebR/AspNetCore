using AspNetCoreEmpty.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEmpty.Models.Contexts
{
    public class DataContext :  DbContext

    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string cString = "Server=LAPTOP-6I4SKCDS;Database=P237;Trusted_Connection=True;MultipleActiveResultSets=true;";
            optionsBuilder.UseSqlServer(cString);   
        }

        public DbSet<Size> Sizes { get; set; }  
    }
}
