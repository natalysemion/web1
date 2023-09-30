namespace C5.Models
{

    public class Event
    {
        public Event() {
            ArtistEvents = new List<ArtistEvent>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public DateTime? DateTime { get; set; }
      //  public int PlaceId { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public virtual ICollection<ArtistEvent> ArtistEvents { get; set; }
    }

}
