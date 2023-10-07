using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class CreateProjectTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timesheet_Contractor_ContractorId",
                table: "Timesheet");

            migrationBuilder.RenameColumn(
                name: "ContractorId",
                table: "Timesheet",
                newName: "ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Timesheet_ContractorId",
                table: "Timesheet",
                newName: "IX_Timesheet_ProjectId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 16, 29, 52, 504, DateTimeKind.Local).AddTicks(6400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 15, 12, 39, 706, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 16, 29, 52, 504, DateTimeKind.Local).AddTicks(4082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 15, 12, 39, 706, DateTimeKind.Local).AddTicks(2944));

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ContractorId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 6, 16, 29, 52, 504, DateTimeKind.Local).AddTicks(6681))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheet_Project_ProjectId",
                table: "Timesheet",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timesheet_Project_ProjectId",
                table: "Timesheet");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Timesheet",
                newName: "ContractorId");

            migrationBuilder.RenameIndex(
                name: "IX_Timesheet_ProjectId",
                table: "Timesheet",
                newName: "IX_Timesheet_ContractorId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 15, 12, 39, 706, DateTimeKind.Local).AddTicks(5230),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 16, 29, 52, 504, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 15, 12, 39, 706, DateTimeKind.Local).AddTicks(2944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 16, 29, 52, 504, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheet_Contractor_ContractorId",
                table: "Timesheet",
                column: "ContractorId",
                principalTable: "Contractor",
                principalColumn: "Id");
        }
    }
}
