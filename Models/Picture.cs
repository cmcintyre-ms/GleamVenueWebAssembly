namespace GleamVenueWebAssembly.Models
{
    public class Picture
    {
        public Guid PictureId { get; set; }
        public string PictureLink { get; set; }
        public GleamVenue GleamVenue { get; set; }
    }
}
