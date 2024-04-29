using Microsoft.EntityFrameworkCore;
using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Entities;

namespace TaylorSwiftAlbumRanker.Services
{
    public class UsersService : IUsersService
    {
        private readonly DataContext _context;

        public UsersService(DataContext context)
        {
            _context = context;
        }

        public async Task<User> AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
           
            return user;
        }

        public async Task<bool> DeleteUser(int id)
        {
            var dbUser = await _context.Users.FindAsync(id);
            if (dbUser != null)
            {
                _context.Remove(dbUser);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<List<User>> GetAllUsers()    
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.FindAsync(id);  
        }

        public async Task<int> GetUsersCount()
        {
            return await _context.Users.CountAsync();
        }

        public async Task<User> UpdateUser(User user)
        {
            var dbUser = await _context.Users.FindAsync(user.Username);
            if (dbUser != null)
            {
                dbUser.Username = user.Username;
                await _context.SaveChangesAsync();
                return dbUser;
            }
            throw new Exception("User not found.");
        }
    }
}
