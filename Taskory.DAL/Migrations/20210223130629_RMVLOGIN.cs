using Microsoft.EntityFrameworkCore.Migrations;

namespace Taskory.DAL.Migrations
{
    public partial class RMVLOGIN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Logins_LoginID",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Logins",
                table: "Logins");

            migrationBuilder.RenameTable(
                name: "Logins",
                newName: "Login");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Login_LoginID",
                table: "Users",
                column: "LoginID",
                principalTable: "Login",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Login_LoginID",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.RenameTable(
                name: "Login",
                newName: "Logins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logins",
                table: "Logins",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Logins_LoginID",
                table: "Users",
                column: "LoginID",
                principalTable: "Logins",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
