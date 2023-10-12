using System.Transactions;

namespace GleamVenueWebAssembly.Models
{
    public class GleamVenue
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        //public string Website { get; set; }
        //public SocialMedia SocialMedias { get; set; }
        //public List<Picture> Pictures { get; set; } = new List<Picture>();
        public string Description { get; set; }
        //public string Coordinates { get; set; }
        //public City City { get; set; }
        //public Guid CityId { get; set; }
        //public List<Email> Emails { get; set; } = new List<Email>();
        public Address Address { get; set; } = new Address();
        public SocialMedia SocialMedia { get; set; } = new SocialMedia();
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
