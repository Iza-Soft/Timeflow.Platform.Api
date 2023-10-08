using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class CreateTimesheetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 15, 12, 39, 706, DateTimeKind.Local).AddTicks(2944),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 14, 24, 34, 247, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.CreateTable(
                name: "Timesheet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractorId = table.Column<int>(type: "int", nullable: false),
                    DayOfMonth = table.Column<int>(type: "int", nullable: false),
                    MonthOfYear = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    DayOfWeek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Month = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkingHours = table.Column<double>(type: "float", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 6, 15, 12, 39, 706, DateTimeKind.Local).AddTicks(5230))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timesheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timesheet_Contractor_ContractorId",
                        column: x => x.ContractorId,
                        principalTable: "Contractor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Timesheet_ContractorId",
                table: "Timesheet",
                column: "ContractorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Timesheet");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 14, 24, 34, 247, DateTimeKind.Local).AddTicks(6757),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 15, 12, 39, 706, DateTimeKind.Local).AddTicks(2944));
        }
    }
}
