using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaylorSwiftAlbumRanker.Entities
{
    public class Permission
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PermissionName")]
        public required string PermissionName { get; set; }
        public required string PermissionDescription { get; set; }
    }
}
