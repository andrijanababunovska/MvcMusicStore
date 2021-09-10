using System;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string AlbumArtUrl { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }

        // navigational property
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
    }
}