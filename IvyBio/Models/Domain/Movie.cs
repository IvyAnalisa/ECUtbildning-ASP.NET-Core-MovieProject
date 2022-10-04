


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IvyBio.Models.Domain
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(100)]
        public string Title { get; set; }

        public string Year { get; set; }
        public string Plot { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Rate { get; set; }
        public Uri Trailer { get; set; }
        public Uri ImageUrl { get; set; }


        [ForeignKey("Genre")]
        public int GenreId { get; set; }

        public virtual Genre Genre { get; set; }


        [MaxLength(50)]
        public string UrlSlug { get; set; }

    }
}
