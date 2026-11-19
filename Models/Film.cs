using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UKWShop.Models
{
    public class Film
    {


        public int Id { get; set; }
        //public string FilmId { get; set; }

        [Required(ErrorMessage = "The title is required.")]

        [StringLength(100, ErrorMessage = "The title cannot exceed 100 characters.")]
        public string Title { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        //nazwa klasy dołączanej + nazwa PK
        //[ForeignKey("Category")]
        public int CategoryId { get; set; }

        //nazwa  klasy dołączanej + Id

    }
}