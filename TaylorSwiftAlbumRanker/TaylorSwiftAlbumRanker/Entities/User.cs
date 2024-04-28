namespace TaylorSwiftAlbumRanker.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required int RolePermission { get; set; }
    }
}
