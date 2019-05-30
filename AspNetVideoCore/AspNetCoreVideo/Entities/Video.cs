using AspNetCoreVideo.Models;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreVideo.Entities
{
    public class Video
    {
        internal object _videos;

        public int Id { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Title { get; set; }
        [Display(Name = "Film Genre")]
        public Genres Genre { get; set; }
    }
}
