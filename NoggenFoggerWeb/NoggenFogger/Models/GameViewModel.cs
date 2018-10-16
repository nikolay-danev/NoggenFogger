using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoggenFogger.Models
{
    public class GameViewModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Author")]
        public string Author { get; set; }

        [Required]
        [Display(Name = "ImageUrl")]
        public string ImageUrl { get; set; }

        [Required]
        [Display(Name = "Video Trailer Url")]
        public string VideoTrailer { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Download Link")]
        public string DownloadLink { get; set; }

        public int LikesCount { get; set; }
    }
}
