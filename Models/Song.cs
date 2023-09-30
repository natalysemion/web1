namespace C5.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lyrics { get; set; }
        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
