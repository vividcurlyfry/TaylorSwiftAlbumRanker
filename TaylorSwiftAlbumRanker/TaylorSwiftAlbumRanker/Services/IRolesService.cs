using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public interface IRolesService
    {
        Task<Role> GetRoleById(int id);     }
}
