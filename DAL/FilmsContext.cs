using Microsoft.EntityFrameworkCore;
using UKWShop.Models;

namespace UKWShop.DAL
{
    public class FilmsContext : DbContext
    {
        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {
        }

        protected FilmsContext()
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Film> Films { get; set; }
    }
}
