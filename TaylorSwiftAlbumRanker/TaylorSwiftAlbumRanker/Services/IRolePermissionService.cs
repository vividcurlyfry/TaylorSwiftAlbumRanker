using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public interface IRolePermissionService
    {
        Task<Role> GetRoleOfUser(int userId);
        Task<List<Permission>> GetPermissionsOfRole(int roleId); 
    }
}
