using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public interface IRolesService
    {
        Task<Role> GetRoleByName(string name);    
        Task<List<Role>> GetAllRoles();
    }
}
