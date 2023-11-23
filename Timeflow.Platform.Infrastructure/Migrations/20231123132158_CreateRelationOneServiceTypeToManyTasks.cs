using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class CreateRelationOneServiceTypeToManyTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(4409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 5, 3, 581, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(2369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 5, 3, 581, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.AddColumn<int>(
                name: "ServiceTypeId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(4131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 5, 3, 581, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(1916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 5, 3, 581, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ServiceTypeId",
                table: "Tasks",
                column: "ServiceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ServiceTypes_ServiceTypeId",
                table: "Tasks",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ServiceTypes_ServiceTypeId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ServiceTypeId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ServiceTypeId",
                table: "Tasks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 5, 3, 581, DateTimeKind.Local).AddTicks(9414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 5, 3, 581, DateTimeKind.Local).AddTicks(8006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 5, 3, 581, DateTimeKind.Local).AddTicks(9119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 5, 3, 581, DateTimeKind.Local).AddTicks(7622),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(1916));
        }
    }
}
