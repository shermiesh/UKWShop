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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categories = new List<Category>()
    {
        new Category()
        {
            Id = 1,
            Name = "Horror",
            Desc = "Filmy grozy"
        },
        new Category()
        {
            Id = 2,
            Name = "Komedia",
            Desc = "Filmy komediowe pełne humoru i zabawnych sytuacji"
        },
        new Category()
        {
            Id = 3,
            Name = "Akcja",
            Desc = "Filmy pełne dynamicznych scen, walk i pościgów"
        },
        new Category()
        {
            Id = 4,
            Name = "Science Fiction",
            Desc = "Filmy o przyszłości, kosmosie i zaawansowanej technologii"
        },
        new Category()
        {
            Id = 5,
            Name = "Dramat",
            Desc = "Filmy poruszające trudne tematy i ludzkie emocje"
        },
        new Category()
        {
            Id = 6,
            Name = "Thriller",
            Desc = "Filmy pełne napięcia, tajemnic i nieoczekiwanych zwrotów akcji"
        }
    };

            modelBuilder.Entity<Category>().HasData(categories);
        }

    }
}
