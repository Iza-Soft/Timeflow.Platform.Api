using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class CreateCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 61, DateTimeKind.Local).AddTicks(2367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 61, DateTimeKind.Local).AddTicks(3261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(9261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 60, DateTimeKind.Local).AddTicks(9937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 61, DateTimeKind.Local).AddTicks(3500))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_CustomerId",
                table: "Project",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Customer_CustomerId",
                table: "Project",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Customer_CustomerId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Project_CustomerId",
                table: "Project");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Timesheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(8871),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 61, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(9261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 61, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 7, 21, 29, 52, 148, DateTimeKind.Local).AddTicks(5779),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 7, 21, 53, 12, 60, DateTimeKind.Local).AddTicks(9937));
        }
    }
}
