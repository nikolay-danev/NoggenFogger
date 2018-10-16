using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoggenFogger.Data.Entities
{
    public class Game
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string ImageUrl { get; set; }

        public string VideoTrailer { get; set; }

        public string Description { get; set; }

        public string DownloadLink { get; set; }

        public User Creator { get; set; }

        [NotMapped]
        public int LikesCount { get; set; }
    }
}
