using Microsoft.EntityFrameworkCore.Migrations;
using TaylorSwiftAlbumRanker.Entities;

#nullable disable

namespace TaylorSwiftAlbumRanker.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: tableUsers => new
                {
                    Id = tableUsers.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1,1"),
                    Username = tableUsers.Column<string>(type: "nvarchar(max)", nullable: true),
                    RolePermission = tableUsers.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: tableAlbums => new
                {
                    Id = tableAlbums.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1,1"),
                    AlbumName = tableAlbums.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureHyperlink = tableAlbums.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });
                    
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
            migrationBuilder.DropTable(
                name: "Albums");
        }
    }
}
