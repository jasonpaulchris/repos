using AspNetCoreVideo.Models;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreVideo.ViewModels
{
    public class VideoEditViewModel
    {
        public Genres Genre { get; set; }
        [Required, MinLength(3)]
        public string Title { get; set; }
        public int Id { get; set; }
    }
}
