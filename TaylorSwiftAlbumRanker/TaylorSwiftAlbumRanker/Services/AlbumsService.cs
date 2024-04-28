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

        public async Task<Album> AddAlbum(Album album)
        {
            _context.Albums.Add(album);
            await _context.SaveChangesAsync();

            return album;
        }

        public async Task<List<Album>> GetAlbums()
        {
            var albums = await _context.Albums.ToListAsync();
            return albums;
        }
    }
}
