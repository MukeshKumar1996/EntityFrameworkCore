using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
            
        }
    }
}
