using System.ComponentModel.DataAnnotations;

namespace IvyBio.Models.Domain
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }


        [MaxLength(100)]
        public string GenreName { get; set; }

    }
}
