using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class AddColumnsAmountAndPaymentTypeIdInTaskTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 16, 27, 36, 525, DateTimeKind.Local).AddTicks(610),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 16, 27, 36, 524, DateTimeKind.Local).AddTicks(7386),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.AddColumn<decimal>(
                name: "PaymentAmount",
                table: "Tasks",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PaymentTypeId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 16, 27, 36, 525, DateTimeKind.Local).AddTicks(276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 16, 27, 36, 524, DateTimeKind.Local).AddTicks(6753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(1916));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentAmount",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "PaymentTypeId",
                table: "Tasks");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(4409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 16, 27, 36, 525, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(2369),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 16, 27, 36, 524, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(4131),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 16, 27, 36, 525, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 23, 15, 21, 58, 134, DateTimeKind.Local).AddTicks(1916),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 23, 16, 27, 36, 524, DateTimeKind.Local).AddTicks(6753));
        }
    }
}
