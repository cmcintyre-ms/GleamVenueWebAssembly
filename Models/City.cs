namespace GleamVenueWebAssembly.Models
{
    public class City
    {
        public Guid CityId { get; set; }
        public string CityName { get; set; }
        public List<GleamVenue> GleamVenues { get; set; } = new List<GleamVenue>();
    }
}
