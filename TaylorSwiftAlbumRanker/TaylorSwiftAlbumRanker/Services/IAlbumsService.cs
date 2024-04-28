using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public interface IAlbumsService
    {
        Task<List<Album>> GetAlbums(); 
        Task<Album> AddAlbum(Album album);
    }
}
