using Discoteque.Data.Models;

namespace Discoteque.Business.IServices;

public interface IArtistService
{
    Task<IEnumerable<Artist>> GetArtistsAsync();
    Task<Artist> GetById(int id);
    Task<Artist> CrateArtist(Artist artist);
    Task<Artist> UpdateArtist(Artist artist);
}