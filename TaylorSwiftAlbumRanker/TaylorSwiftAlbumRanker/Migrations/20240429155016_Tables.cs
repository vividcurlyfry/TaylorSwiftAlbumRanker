using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using TaylorSwiftAlbumRanker.Entities;

#nullable disable

namespace TaylorSwiftAlbumRanker.Migrations
{
    /// <inheritdoc />
    public partial class Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Albums",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   AlbumName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                   PictureHyperlink = table.Column<string>(type: "nvarchar(450)", nullable: false),
                   Ranking = table.Column<int>(type: "int", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Albums", x => x.Id);
               });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionDescription = table.Column<string>(type: "nvarchar(900)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionName);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(900)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleName);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                    table.ForeignKey("PK_RP_RoleName", x => x.RoleName, "Roles","RoleName");
                    table.ForeignKey("PK_RP_PermissionName", x => x.PermissionName, "Permissions", "PermissionName");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                 name: "UserRoles",
                 columns: table => new
                 {
                     Id = table.Column<int>(type: "int", nullable: false)
                         .Annotation("SqlServer:Identity", "1, 1"),
                     UserId = table.Column<int>(type: "int", nullable: false),
                     RoleName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                 },
                 constraints: table =>
                 {
                     table.PrimaryKey("PK_UserRoles", x => x.Id);
                     table.ForeignKey("PK_UR_Username", x => x.UserId, "Users", "Id");
                     table.ForeignKey("PK_UR_RoleName", x => x.RoleName, "Roles", "RoleName");
                 });

            migrationBuilder.InsertData(
            table: "Permissions",
            columns: new[] { "PermissionName", "PermissionDescription" },
            values: new object[,]
            {
                { "AddUser", "Ability to add users."},
                { "DeleteUser", "Ability to delete users."},
                { "EditUserRole", "Ability to edit user roles."},
                { "ViewAlbums", "Ability to view all albums."},
                { "EditAlbums", "Ability to edit albums."}
            });

            migrationBuilder.InsertData(
            table: "Roles",
            columns: new[] { "RoleName", "RoleDescription" },
            values: new object[,]
            {
                { "Admin", "Permission to do everything!"},
                { "UserController", "Permission to add, edit and delete users."},
                { "AlbumViewer", "Permission to view and rank albums."},
                { "AlbumEditer", "Permission to edit albums."}
            });

            migrationBuilder.Sql(@"INSERT INTO[dbo].[RolePermissions]
           ([RoleName],[PermissionName])
             VALUES
            ('Admin', 'AddUser'),
            ('Admin', 'DeleteUser'),
            ('Admin', 'EditUserRole'),
            ('Admin', 'ViewAlbums'),
            ('Admin', 'EditAlbums'),
            ('UserController', 'AddUser'),
            ('UserController', 'DeleteUser'),
            ('UserController', 'EditUserRole'),
            ('AlbumViewer', 'ViewAlbums'),
            ('AlbumEditer', 'EditAlbums'),
            ('AlbumEditer', 'ViewAlbums')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
