using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class FKContractorToHourlyRateManyToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 19, DateTimeKind.Local).AddTicks(5027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 19, DateTimeKind.Local).AddTicks(6270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HourlyRate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 20, DateTimeKind.Local).AddTicks(504),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 19, DateTimeKind.Local).AddTicks(6700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Currency",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 19, DateTimeKind.Local).AddTicks(6955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 19, DateTimeKind.Local).AddTicks(1197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 505, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.CreateIndex(
                name: "IX_HourlyRate_ContractId",
                table: "HourlyRate",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_HourlyRate_Contractor_ContractId",
                table: "HourlyRate",
                column: "ContractId",
                principalTable: "Contractor",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HourlyRate_Contractor_ContractId",
                table: "HourlyRate");

            migrationBuilder.DropIndex(
                name: "IX_HourlyRate_ContractId",
                table: "HourlyRate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 19, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 19, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HourlyRate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(2851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 20, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 19, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Currency",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 19, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 505, DateTimeKind.Local).AddTicks(7125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 16, 28, 19, DateTimeKind.Local).AddTicks(1197));
        }
    }
}
