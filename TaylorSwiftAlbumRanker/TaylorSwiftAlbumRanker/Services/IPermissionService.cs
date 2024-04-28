using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public interface IPermissionsService
    {
        Task<Permission> GetPermissionById(int id);     }
}
