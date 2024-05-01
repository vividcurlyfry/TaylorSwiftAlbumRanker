using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public interface IAlbumsService
    {
        Task<List<Album>> GetAllAlbums(); 
        Task<Album> EditAlbum(Album album);
        Task<Album> GetAlbum(int id);
    }
}
