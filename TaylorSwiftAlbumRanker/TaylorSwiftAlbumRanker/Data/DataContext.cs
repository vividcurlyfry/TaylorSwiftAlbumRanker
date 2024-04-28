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
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Ranking> Ranking { get; set; }
    }
}
