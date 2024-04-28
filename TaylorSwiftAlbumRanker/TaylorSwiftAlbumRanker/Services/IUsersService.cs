using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public interface IUsersService
    {
        Task<List<User>> GetAllUsers();
        Task<User> AddUser(User user);
    }
}
