using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaylorSwiftAlbumRanker.Migrations
{
    /// <inheritdoc />
    public partial class UserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanPerform",
                table: "RolePermissions");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Username);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.AddColumn<bool>(
                name: "CanPerform",
                table: "RolePermissions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
