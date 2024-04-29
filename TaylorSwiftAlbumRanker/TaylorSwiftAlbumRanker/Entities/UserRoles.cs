using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaylorSwiftAlbumRanker.Entities
{
    public class UserRoles
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string RoleName { get; set; }
    }
}
