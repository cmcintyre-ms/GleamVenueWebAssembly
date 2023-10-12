namespace GleamVenueWebAssembly.Models
{
    public class Email
    {
        public Guid EmailId { get; set; }
        public string EmailAddress { get; set; }
        public Guid VenueId { get; set; }
        public GleamVenue GleamVenue { get; set; }
    }
}
