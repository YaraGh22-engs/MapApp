
using GoogleMapApp.Models;
using Microsoft.EntityFrameworkCore;
 

namespace Shopping_Cart_2.Data
{
    public class ApplicationDbContext   : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Store> stores { get; set; }
         
    }
}
