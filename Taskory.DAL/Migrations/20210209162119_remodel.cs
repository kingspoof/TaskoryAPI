using Microsoft.EntityFrameworkCore.Migrations;

namespace Taskory.DAL.Migrations
{
    public partial class remodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Organisations_OrganisationID1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_OrganisationID1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OrganisationID1",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "AuthentificationTempelate",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdministratorID",
                table: "Organisations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organisations_AdministratorID",
                table: "Organisations",
                column: "AdministratorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Organisations_Users_AdministratorID",
                table: "Organisations",
                column: "AdministratorID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organisations_Users_AdministratorID",
                table: "Organisations");

            migrationBuilder.DropIndex(
                name: "IX_Organisations_AdministratorID",
                table: "Organisations");

            migrationBuilder.DropColumn(
                name: "AuthentificationTempelate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AdministratorID",
                table: "Organisations");

            migrationBuilder.AddColumn<int>(
                name: "OrganisationID1",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganisationID1",
                table: "Users",
                column: "OrganisationID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Organisations_OrganisationID1",
                table: "Users",
                column: "OrganisationID1",
                principalTable: "Organisations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
