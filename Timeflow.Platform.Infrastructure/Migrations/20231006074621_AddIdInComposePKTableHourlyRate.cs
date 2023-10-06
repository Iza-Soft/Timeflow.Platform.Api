using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class AddIdInComposePKTableHourlyRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HourlyRate",
                table: "HourlyRate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(7832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(7643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HourlyRate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(9325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(7364),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Currency",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(8052),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(5958),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.AddPrimaryKey(
                name: "PK_HourlyRate",
                table: "HourlyRate",
                columns: new[] { "Id", "ProjectId", "ContractorId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HourlyRate",
                table: "HourlyRate");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(5880),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(5635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "HourlyRate",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(7037),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(5341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Currency",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(6081),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 6, 10, 30, 51, 317, DateTimeKind.Local).AddTicks(3997),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 6, 10, 46, 21, 534, DateTimeKind.Local).AddTicks(5958));

            migrationBuilder.AddPrimaryKey(
                name: "PK_HourlyRate",
                table: "HourlyRate",
                columns: new[] { "ProjectId", "ContractorId" });
        }
    }
}
