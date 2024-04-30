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

        public async Task<List<UserRoles>> GetAllRolesForUser(string username)
        {
            return await _context.UserRoles.Where(ur => ur.Username == username).ToListAsync();
        }

        public async Task<UserRoles> GetRecordOfUserRole(string username, string rolename)
        {
            var user_roles = await _context.UserRoles.Where(ur => ur.Username.Equals(username) && ur.RoleName.Equals(rolename)).ToListAsync();
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
