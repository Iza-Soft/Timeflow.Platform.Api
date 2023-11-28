using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timeflow.Platform.Infrastructure.Migrations
{
    public partial class RemovePluralInDBTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ServiceTypes_ServiceTypeId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSheets_Tasks_TaskId",
                table: "TimeSheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeSheets",
                table: "TimeSheets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentTypes",
                table: "PaymentTypes");

            migrationBuilder.RenameTable(
                name: "TimeSheets",
                newName: "TimeSheet");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Task");

            migrationBuilder.RenameTable(
                name: "ServiceTypes",
                newName: "ServiceType");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "PaymentTypes",
                newName: "PaymentType");

            migrationBuilder.RenameIndex(
                name: "IX_TimeSheets_TaskId",
                table: "TimeSheet",
                newName: "IX_TimeSheet_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ServiceTypeId",
                table: "Task",
                newName: "IX_Task_ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ProjectId",
                table: "Task",
                newName: "IX_Task_ProjectId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(3255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(3063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Task",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(1030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(2936),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Project",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PaymentType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(4301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeSheet",
                table: "TimeSheet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Task",
                table: "Task",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceType",
                table: "ServiceType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentType",
                table: "PaymentType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Project_ProjectId",
                table: "Task",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_ServiceType_ServiceTypeId",
                table: "Task",
                column: "ServiceTypeId",
                principalTable: "ServiceType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheet_Task_TaskId",
                table: "TimeSheet",
                column: "TaskId",
                principalTable: "Task",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Project_ProjectId",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_ServiceType_ServiceTypeId",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeSheet_Task_TaskId",
                table: "TimeSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TimeSheet",
                table: "TimeSheet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Task",
                table: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceType",
                table: "ServiceType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentType",
                table: "PaymentType");

            migrationBuilder.RenameTable(
                name: "TimeSheet",
                newName: "TimeSheets");

            migrationBuilder.RenameTable(
                name: "Task",
                newName: "Tasks");

            migrationBuilder.RenameTable(
                name: "ServiceType",
                newName: "ServiceTypes");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "PaymentType",
                newName: "PaymentTypes");

            migrationBuilder.RenameIndex(
                name: "IX_TimeSheet_TaskId",
                table: "TimeSheets",
                newName: "IX_TimeSheets_TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Task_ServiceTypeId",
                table: "Tasks",
                newName: "IX_Tasks_ServiceTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Task_ProjectId",
                table: "Tasks",
                newName: "IX_Tasks_ProjectId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TimeSheets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(3063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(899),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ServiceTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(2767),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PaymentTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 25, 23, 28, 15, 995, DateTimeKind.Local).AddTicks(3998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 25, 23, 32, 26, 739, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TimeSheets",
                table: "TimeSheets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceTypes",
                table: "ServiceTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentTypes",
                table: "PaymentTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_ProjectId",
                table: "Tasks",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ServiceTypes_ServiceTypeId",
                table: "Tasks",
                column: "ServiceTypeId",
                principalTable: "ServiceTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeSheets_Tasks_TaskId",
                table: "TimeSheets",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id");
        }
    }
}
