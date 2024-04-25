namespace TaylorSwiftAlbumRanker.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string RolePermission { get; set; }
    }
}
