using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaylorSwiftAlbumRanker.Entities
{
    public class Role
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RoleName")]
        public required string RoleName { get; set; }
        public required string RoleDescription { get; set; }
    }
}
