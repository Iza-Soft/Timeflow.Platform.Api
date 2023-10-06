using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class AddFKOneCurrencyToOneHourlyRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 90, DateTimeKind.Local).AddTicks(6153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 90, DateTimeKind.Local).AddTicks(5868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HourlyRate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 91, DateTimeKind.Local).AddTicks(722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 90, DateTimeKind.Local).AddTicks(5513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(3452));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Currency",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 91, DateTimeKind.Local).AddTicks(236),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 90, DateTimeKind.Local).AddTicks(3349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.CreateIndex(
                name: "IX_HourlyRate_CurrencyId",
                table: "HourlyRate",
                column: "CurrencyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HourlyRate_Currency_CurrencyId",
                table: "HourlyRate",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(3933),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 90, DateTimeKind.Local).AddTicks(6153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(3703),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 90, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HourlyRate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(4341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 91, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(3452),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 90, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Currency",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(4122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 91, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 5, 14, 38, 46, 977, DateTimeKind.Local).AddTicks(2056),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 13, 31, 19, 90, DateTimeKind.Local).AddTicks(3349));
        }
    }
}
