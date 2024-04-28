using Microsoft.EntityFrameworkCore;
using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public class RolesService : IRolesService
    {
        private readonly DataContext _context;

        public RolesService(DataContext context)
        {
            _context = context;
        }

        public Task<Role> GetRoleById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
