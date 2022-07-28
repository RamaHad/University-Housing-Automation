using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class setusernameuniqe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_units_user_UserFk",
                table: "units");

            migrationBuilder.DropForeignKey(
                name: "FK_unitStores_user_UserFk",
                table: "unitStores");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_RoleId",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "users");

            migrationBuilder.RenameIndex(
                name: "IX_user_RoleId",
                table: "users",
                newName: "IX_users_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_users_UserName",
                table: "users",
                column: "UserName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_units_users_UserFk",
                table: "units",
                column: "UserFk",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_unitStores_users_UserFk",
                table: "unitStores",
                column: "UserFk",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_role_RoleId",
                table: "users",
                column: "RoleId",
                principalTable: "role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_units_users_UserFk",
                table: "units");

            migrationBuilder.DropForeignKey(
                name: "FK_unitStores_users_UserFk",
                table: "unitStores");

            migrationBuilder.DropForeignKey(
                name: "FK_users_role_RoleId",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_UserName",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "user");

            migrationBuilder.RenameIndex(
                name: "IX_users_RoleId",
                table: "user",
                newName: "IX_user_RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "user",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_units_user_UserFk",
                table: "units",
                column: "UserFk",
                principalTable: "user",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_unitStores_user_UserFk",
                table: "unitStores",
                column: "UserFk",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_RoleId",
                table: "user",
                column: "RoleId",
                principalTable: "role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
