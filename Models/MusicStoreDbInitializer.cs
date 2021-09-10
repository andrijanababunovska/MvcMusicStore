using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer : CreateDatabaseIfNotExists<MusicStoreDb>
    {
        protected override void Seed(MusicStoreDb context)
        {
            // Artists
            context.Artists.Add(new Artist { ArtistId = 1, Name = "Madonna" });
            context.Artists.Add(new Artist { ArtistId = 2, Name = "John Lennon" });
            context.Artists.Add(new Artist { ArtistId = 3, Name = "Michael Jackson" });
            context.Artists.Add(new Artist { ArtistId = 4, Name = "Prince" });

            // Genres
            context.Genres.Add(new Genre { GenreId = 1, Name = "Rock" });
            context.Genres.Add(new Genre { GenreId = 2, Name = "Blues" });
            context.Genres.Add(new Genre { GenreId = 3, Name = "Pop" });
            context.Genres.Add(new Genre { GenreId = 4, Name = "Hip hop" });

            // Albums
            context.Albums.Add(new Album
            {
                AlbumId = 1,
                Title = "Thriller",
                Artist = new Artist { Name = "Michael Jackson" },
                Price = 49.99M,
                Genre = new Genre { Name = "Pop" }
            });

            base.Seed(context);
        }

    }
}