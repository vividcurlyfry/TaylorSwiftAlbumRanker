using Microsoft.EntityFrameworkCore;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        
        }
        
        public DbSet <User> Users { get; set; } 
        public DbSet<Album> Albums { get; set; }
    }
}
