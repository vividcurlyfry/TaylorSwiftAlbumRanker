using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public interface IRolePermissionsService
    {
        Task<RolePermissions> GetRolePermissionById(int id);
        Task<List<RolePermissions>> GetPermissionsOfRole(string roleName); 
    }
}
