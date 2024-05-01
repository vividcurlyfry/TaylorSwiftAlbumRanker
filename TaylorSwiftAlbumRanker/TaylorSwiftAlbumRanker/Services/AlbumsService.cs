using Microsoft.EntityFrameworkCore;
using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public class AlbumsService : IAlbumsService
    {
        private readonly DataContext _context;

        public AlbumsService(DataContext context)
        {
            _context = context;
        }

        public async Task<Album> EditAlbum(Album album)
        {
            var dbAlbum = await _context.Albums.FindAsync(album.Id);
            if (dbAlbum != null)
            {
                dbAlbum.PictureHyperlink = album.PictureHyperlink;
                dbAlbum.NumRanking = album.NumRanking;
                await _context.SaveChangesAsync();
                return dbAlbum;
            }
            throw new Exception("Album not found.");
        }

        public async Task<Album> GetAlbum(int id)
        {
            return await _context.Albums.FindAsync(id);
        }

        public async Task<List<Album>> GetAllAlbums()
        {
            var albums = await _context.Albums.ToListAsync();
            return albums;
        }
    }
}
