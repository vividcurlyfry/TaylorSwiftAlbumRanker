namespace TaylorSwiftAlbumRanker.Entities
{
    public class RolePermissions
    {
        public int Id { get; set; }
        public required string RoleName { get; set; }
        public required string PermissionName { get; set; }
    }
}
