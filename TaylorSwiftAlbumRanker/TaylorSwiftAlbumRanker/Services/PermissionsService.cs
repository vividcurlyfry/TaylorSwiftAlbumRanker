using Microsoft.EntityFrameworkCore;
using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public class PermissionsService : IPermissionsService
    {
        private readonly DataContext _context;

        public PermissionsService(DataContext context)
        {
            _context = context;
        }

        public Task<Permission> GetPermissionById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
