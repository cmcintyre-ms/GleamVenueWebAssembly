namespace GleamVenueWebAssembly.Models
{
    public class VenueType
    {
        public Guid VenueTypeId { get; set; }
        public string VenueTypeName { get; set; } = String.Empty;
        public Guid VenueId { get; set; }
    }
}
