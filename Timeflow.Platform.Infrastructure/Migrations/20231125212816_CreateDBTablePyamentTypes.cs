using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class CreateDBTablePyamentTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(3063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(2767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 59, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(3998)),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(2716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 60, DateTimeKind.Local).AddTicks(2450),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 21, 2, 26, 59, DateTimeKind.Local).AddTicks(9904),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(458));
        }
    }
}
