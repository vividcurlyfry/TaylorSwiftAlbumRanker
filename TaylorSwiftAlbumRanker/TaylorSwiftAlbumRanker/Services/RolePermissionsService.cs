using Microsoft.EntityFrameworkCore;
using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public class RolePermissionService : IRolePermissionService
    {
        private readonly DataContext _context;

        public RolePermissionService(DataContext context)
        {
            _context = context;
        }

        public Task<List<Permission>> GetPermissionsOfRole(int roleId)
        {
            throw new NotImplementedException();
        }

        public Task<Role> GetRoleOfUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
