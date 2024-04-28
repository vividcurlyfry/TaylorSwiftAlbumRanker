namespace TaylorSwiftAlbumRanker.Entities
{
    public class RolePermission
    {
        public int Id { get; set; }
        public required int RoleId { get; set; }
        public required int PermissionId { get; set; }
        public required bool CanPerform { get; set; }
    }
}
