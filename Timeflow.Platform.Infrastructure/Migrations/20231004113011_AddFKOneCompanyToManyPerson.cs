using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class AddFKOneCompanyToManyPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 14, 30, 11, 122, DateTimeKind.Local).AddTicks(7328),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 14, 29, 25, 622, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 14, 30, 11, 122, DateTimeKind.Local).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 14, 29, 25, 622, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 14, 30, 11, 122, DateTimeKind.Local).AddTicks(5713),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 14, 29, 25, 622, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.CreateIndex(
                name: "IX_Contractors_CompanyId",
                table: "Contractors",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contractors_Contractors_CompanyId",
                table: "Contractors",
                column: "CompanyId",
                principalTable: "Contractors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_Contractors_CompanyId",
                table: "Contractors");

            migrationBuilder.DropIndex(
                name: "IX_Contractors_CompanyId",
                table: "Contractors");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 14, 29, 25, 622, DateTimeKind.Local).AddTicks(3335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 14, 30, 11, 122, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 14, 29, 25, 622, DateTimeKind.Local).AddTicks(3027),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 14, 30, 11, 122, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contractors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 14, 29, 25, 622, DateTimeKind.Local).AddTicks(2340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 14, 30, 11, 122, DateTimeKind.Local).AddTicks(5713));
        }
    }
}
