using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class CreateRelationOnePaymentTypeToManyTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 42, 17, 870, DateTimeKind.Local).AddTicks(1587),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Task",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 42, 17, 869, DateTimeKind.Local).AddTicks(6408),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 42, 17, 870, DateTimeKind.Local).AddTicks(833),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 42, 17, 869, DateTimeKind.Local).AddTicks(5610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PaymentType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 42, 17, 870, DateTimeKind.Local).AddTicks(2814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.CreateIndex(
                name: "IX_Task_PaymentTypeId",
                table: "Task",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_PaymentType_PaymentTypeId",
                table: "Task",
                column: "PaymentTypeId",
                principalTable: "PaymentType",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_PaymentType_PaymentTypeId",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_PaymentTypeId",
                table: "Task");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(3255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 42, 17, 870, DateTimeKind.Local).AddTicks(1587));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Task",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(1030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 42, 17, 869, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(2936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 42, 17, 870, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 42, 17, 869, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PaymentType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(4301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 42, 17, 870, DateTimeKind.Local).AddTicks(2814));
        }
    }
}
