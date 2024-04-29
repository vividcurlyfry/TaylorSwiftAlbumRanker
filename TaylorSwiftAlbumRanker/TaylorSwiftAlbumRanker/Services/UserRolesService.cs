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

        public async Task<List<UserRoles>> GetAllRolesForUser(string username)
        {
            return await _context.UserRoles.Where(ur => ur.Username.Equals(username)).ToListAsync();
        }
    }
}
