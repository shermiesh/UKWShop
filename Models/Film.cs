using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UKWShop.Models
{
    public class Film
    {


        public int Id { get; set; }
        //public string FilmId { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany.")]

        [StringLength(100, ErrorMessage = "Tytuł nie może przekraczać 100 znaków.")]
        public string Title { get; set; }
        public string Director { get; set; }

        [StringLength(5000)]
        public string Desc { get; set; }

        public decimal Price { get; set; }
        public DateTime DateAdded { get; set; }

        //nazwa klasy dołączanej + nazwa PK
        //[ForeignKey("Category")]
        public int CategoryId { get; set; }

        //nazwa  klasy dołączanej + Id
        public Category Category { get; set; }

    }
}