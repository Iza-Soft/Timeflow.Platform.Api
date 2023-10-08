using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class CreateHourlyRateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timesheet_Contractor_ContractorId",
                table: "Timesheet");

            migrationBuilder.DropForeignKey(
                name: "FK_Timesheet_Project_ProjectId",
                table: "Timesheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Timesheet",
                table: "Timesheet");

            migrationBuilder.RenameTable(
                name: "Timesheet",
                newName: "TimeSheet");

            migrationBuilder.RenameIndex(
                name: "IX_Timesheet_ProjectId",
                table: "TimeSheet",
                newName: "IX_TimeSheet_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Timesheet_ContractorId",
                table: "TimeSheet",
                newName: "IX_TimeSheet_ContractorId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(4930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(5860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(6137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Currency",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(6371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(2054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 889, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeSheet",
                table: "TimeSheet",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "HourlyRate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(6569))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourlyRate", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheet_Contractor_ContractorId",
                table: "TimeSheet",
                column: "ContractorId",
                principalTable: "Contractor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheet_Project_ProjectId",
                table: "TimeSheet",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeSheet_Contractor_ContractorId",
                table: "TimeSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSheet_Project_ProjectId",
                table: "TimeSheet");

            migrationBuilder.DropTable(
                name: "HourlyRate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeSheet",
                table: "TimeSheet");

            migrationBuilder.RenameTable(
                name: "TimeSheet",
                newName: "Timesheet");

            migrationBuilder.RenameIndex(
                name: "IX_TimeSheet_ProjectId",
                table: "Timesheet",
                newName: "IX_Timesheet_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeSheet_ContractorId",
                table: "Timesheet",
                newName: "IX_Timesheet_ContractorId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(2042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(3019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(3341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Currency",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(3594),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 889, DateTimeKind.Local).AddTicks(9372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Timesheet",
                table: "Timesheet",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheet_Contractor_ContractorId",
                table: "Timesheet",
                column: "ContractorId",
                principalTable: "Contractor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheet_Project_ProjectId",
                table: "Timesheet",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");
        }
    }
}
