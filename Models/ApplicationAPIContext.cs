
using Microsoft.EntityFrameworkCore;
namespace C5.Models
{

    public class ApplicationAPIContext : DbContext
    {

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<ArtistEvent> ArtistEvent { get; set; }

        public ApplicationAPIContext(DbContextOptions<ApplicationAPIContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
    }
}