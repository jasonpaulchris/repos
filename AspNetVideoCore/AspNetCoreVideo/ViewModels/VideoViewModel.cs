using System.ComponentModel.DataAnnotations;

namespace AspNetCoreVideo.ViewModels
{
    public class VideoViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Genre { get; set; }
    }
}
