using Microsoft.EntityFrameworkCore;
using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public class RolePermissionsService : IRolePermissionsService
    {
        private readonly DataContext _context;

        public RolePermissionsService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<RolePermissions>> GetPermissionsOfRole(string roleName)
        {
            return await _context.RolePermissions.Where(rp => rp.RoleName.Equals(roleName)).ToListAsync();
        }

        public async Task<RolePermissions> GetRolePermissionById(int id)
        {
            return await _context.RolePermissions.FindAsync(id);
        }
    }
}
