namespace C5.Models
{
    public class ArtistEvent
    { 
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int EventId { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Event Event { get; set; }

    }
}
