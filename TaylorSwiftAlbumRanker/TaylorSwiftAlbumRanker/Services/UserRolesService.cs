using Microsoft.EntityFrameworkCore;
using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public class UserRolesService : IUserRolesService
    {
        private readonly DataContext _context;

        public UserRolesService(DataContext context)
        {
            _context = context;
        }

        public async Task<UserRoles> AddUserRole(UserRoles userRole)
        {
            _context.UserRoles.Add(userRole);
            await _context.SaveChangesAsync();

            return userRole;
        }

        public async Task<bool> DeleteUserRole(int id)
        {
            var dbUserRole = await _context.UserRoles.FindAsync(id);
            if (dbUserRole != null)
            {
                _context.Remove(dbUserRole);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<UserRoles>> GetAllRolesForUser(int id)
        {
            return await _context.UserRoles.Where(ur => ur.userId == id).ToListAsync();
        }

        public async Task<List<int>> GetGroupOfUsersPerRole()
        {
            var count_list = new List<int>();
            var count_a = await _context.UserRoles.CountAsync(o => o.RoleName == "Admin");
            count_list.Add(count_a);

            var count_b = await _context.UserRoles.CountAsync(o => o.RoleName == "AlbumEditer"); 
            count_list.Add(count_b);

            var count_c = await _context.UserRoles.CountAsync(o => o.RoleName == "AlbumViewer");
            count_list.Add(count_c);

            var count_d = await _context.UserRoles.CountAsync(o => o.RoleName == "UserController"); 

            count_list.Add(count_d);
            return count_list;
        }

        public async Task<UserRoles> GetRecordOfUserRole(int userId, string rolename)
        {
            var user_roles = await _context.UserRoles.Where(ur => ur.userId.Equals(userId) && ur.RoleName.Equals(rolename)).ToListAsync();
            if (user_roles.Count == 1)
            {
                return user_roles[0];
            }
            else
            {
                throw new Exception("More than one entity with that username and rolename");
            }
        }
    }
}
