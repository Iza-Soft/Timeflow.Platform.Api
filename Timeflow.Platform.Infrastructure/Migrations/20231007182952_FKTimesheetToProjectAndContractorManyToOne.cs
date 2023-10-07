using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class FKTimesheetToProjectAndContractorManyToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContractorId",
                table: "Project");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(8871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 16, 29, 52, 504, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.AddColumn<int>(
                name: "ContractorId",
                table: "Timesheet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(9261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 16, 29, 52, 504, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(5779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 16, 29, 52, 504, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.CreateIndex(
                name: "IX_Timesheet_ContractorId",
                table: "Timesheet",
                column: "ContractorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Timesheet_Contractor_ContractorId",
                table: "Timesheet",
                column: "ContractorId",
                principalTable: "Contractor",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timesheet_Contractor_ContractorId",
                table: "Timesheet");

            migrationBuilder.DropIndex(
                name: "IX_Timesheet_ContractorId",
                table: "Timesheet");

            migrationBuilder.DropColumn(
                name: "ContractorId",
                table: "Timesheet");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 16, 29, 52, 504, DateTimeKind.Local).AddTicks(6400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 16, 29, 52, 504, DateTimeKind.Local).AddTicks(6681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.AddColumn<int>(
                name: "ContractorId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 16, 29, 52, 504, DateTimeKind.Local).AddTicks(4082),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(5779));
        }
    }
}
