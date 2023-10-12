namespace GleamVenueWebAssembly.Models
{
    public class Review
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string ReviewersEmail { get; set; }

        public Guid GleamVenueId { get; set; }

        public GleamVenue GleamVenue { get; set; }
    }
}

