using DBProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DBProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
    }
}
