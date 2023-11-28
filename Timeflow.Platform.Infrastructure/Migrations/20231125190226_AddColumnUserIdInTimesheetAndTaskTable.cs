using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class AddColumnUserIdInTimesheetAndTaskTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(2716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 18, 19, 16, 545, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "TimeSheets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 18, 19, 16, 544, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Tasks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(2450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 18, 19, 16, 545, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 59, DateTimeKind.Local).AddTicks(9904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 18, 19, 16, 544, DateTimeKind.Local).AddTicks(8502));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TimeSheets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tasks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 18, 19, 16, 545, DateTimeKind.Local).AddTicks(1346),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 18, 19, 16, 544, DateTimeKind.Local).AddTicks(8990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 18, 19, 16, 545, DateTimeKind.Local).AddTicks(1026),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 18, 19, 16, 544, DateTimeKind.Local).AddTicks(8502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 59, DateTimeKind.Local).AddTicks(9904));
        }
    }
}
