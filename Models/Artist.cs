using System.Diagnostics.Metrics;

namespace C5.Models
{
    public class Artist
    {
        public Artist() { 
            Songs = new List<Song>();
            ArtistEvents = new List<ArtistEvent>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Male { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? CountryId { get; set; }
        public string? Photo { get; set; }

        public Country Country { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
        public virtual ICollection<ArtistEvent> ArtistEvents { get; set; } 
    }
}
