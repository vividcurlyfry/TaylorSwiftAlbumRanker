using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public interface IUserRolesService
    {
        Task<List<UserRoles>> GetAllRolesForUser(int userId);
        Task<bool>  DeleteUserRole(int id);
        Task<UserRoles> AddUserRole(UserRoles userRole);
        Task<UserRoles> GetRecordOfUserRole(int userId, string rolename);
        Task<List<int>> GetGroupOfUsersPerRole();
    }
}
