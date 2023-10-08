using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class CreateCurrencyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(2042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 61, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(3019),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 61, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(3341),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 61, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 889, DateTimeKind.Local).AddTicks(9372),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 60, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(3594))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 61, DateTimeKind.Local).AddTicks(2367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 61, DateTimeKind.Local).AddTicks(3261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 61, DateTimeKind.Local).AddTicks(3500),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 890, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 60, DateTimeKind.Local).AddTicks(9937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 22, 19, 26, 889, DateTimeKind.Local).AddTicks(9372));
        }
    }
}
