using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class FKCurrencyToHourlyRateManyToOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HourlyRate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(2851),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1581),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Currency",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1776),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 505, DateTimeKind.Local).AddTicks(7125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.CreateIndex(
                name: "IX_HourlyRate_CurrencyId",
                table: "HourlyRate",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_HourlyRate_Currency_CurrencyId",
                table: "HourlyRate",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HourlyRate_Currency_CurrencyId",
                table: "HourlyRate");

            migrationBuilder.DropIndex(
                name: "IX_HourlyRate_CurrencyId",
                table: "HourlyRate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(4930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(5860),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HourlyRate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(6569),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(6137),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1581));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Currency",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(6371),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 506, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 8, 16, 58, 48, 42, DateTimeKind.Local).AddTicks(2054),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 8, 17, 10, 13, 505, DateTimeKind.Local).AddTicks(7125));
        }
    }
}
