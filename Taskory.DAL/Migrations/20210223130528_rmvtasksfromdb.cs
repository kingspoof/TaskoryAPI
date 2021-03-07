using Microsoft.EntityFrameworkCore.Migrations;

namespace Taskory.DAL.Migrations
{
    public partial class rmvtasksfromdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Organisations_OrganisationID",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Task");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_OrganisationID",
                table: "Task",
                newName: "IX_Task_OrganisationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Task",
                table: "Task",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Organisations_OrganisationID",
                table: "Task",
                column: "OrganisationID",
                principalTable: "Organisations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Organisations_OrganisationID",
                table: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Task",
                table: "Task");

            migrationBuilder.RenameTable(
                name: "Task",
                newName: "Tasks");

            migrationBuilder.RenameIndex(
                name: "IX_Task_OrganisationID",
                table: "Tasks",
                newName: "IX_Tasks_OrganisationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Organisations_OrganisationID",
                table: "Tasks",
                column: "OrganisationID",
                principalTable: "Organisations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
