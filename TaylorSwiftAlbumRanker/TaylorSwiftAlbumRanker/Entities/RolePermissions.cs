namespace TaylorSwiftAlbumRanker.Entities
{
    public class RolePermissions
    {
        public int Id { get; set; }
        public required int RoleName { get; set; }
        public required int PermissionName { get; set; }
    }
}
