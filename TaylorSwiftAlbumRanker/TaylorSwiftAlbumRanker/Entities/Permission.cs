namespace TaylorSwiftAlbumRanker.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public required string PermissionName { get; set; }
        public required string PermissionDescription { get; set; }
    }
}
