using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public interface IUserRolesService
    {
        Task<List<UserRoles>> GetAllRolesForUser(string username);
        Task<bool>  DeleteUserRole(int id);
        Task<UserRoles> AddUserRole(UserRoles userRole);
        Task<UserRoles> GetRecordOfUserRole(string username, string rolename);
    }
}
