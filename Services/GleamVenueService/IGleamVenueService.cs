using GleamVenueWebAssembly.Models;
using System.Collections.Generic;

namespace GleamVenueWebAssembly.Services.GleamVenueService
{
    public interface IGleamVenueService
    {
        Task<List<GleamVenue>> GetAllGleamVenues();
        Task<GleamVenue> GetGleamVenueById(Guid id);
        Task AddNewVenue(GleamVenue gleamVenue);
    }
}
