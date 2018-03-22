using Microsoft.EntityFrameworkCore;
 
namespace devnotCore.Models
{
    public class FabrikaContext
        :DbContext
    {
        public DbSet<Product> Products{get;set;}
         
        public FabrikaContext(DbContextOptions<FabrikaContext> options)
            :base(options)
            {           
            }
    }
}