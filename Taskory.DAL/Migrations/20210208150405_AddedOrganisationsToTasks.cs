using Microsoft.EntityFrameworkCore.Migrations;

namespace Taskory.DAL.Migrations
{
    public partial class AddedOrganisationsToTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganisationID",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_OrganisationID",
                table: "Tasks",
                column: "OrganisationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Organisations_OrganisationID",
                table: "Tasks",
                column: "OrganisationID",
                principalTable: "Organisations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Organisations_OrganisationID",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_OrganisationID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "OrganisationID",
                table: "Tasks");
        }
    }
}
