using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public interface IUserRolesService
    {
        Task<List<UserRoles>> GetAllRolesForUser(string username);
    }
}
