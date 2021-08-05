using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicalPassport.Migrations
{
    public partial class addStudentCompletedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "StudentCompleted",
                table: "TaskCompletions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 1,
                columns: new[] { "InitialDate", "PreceptorInitial", "StudentCompleted" },
                values: new object[] { new DateTime(2021, 8, 3, 19, 18, 10, 698, DateTimeKind.Local).AddTicks(7537), "", true });

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 2,
                columns: new[] { "InitialDate", "StudentCompleted" },
                values: new object[] { new DateTime(2021, 8, 3, 19, 18, 10, 702, DateTimeKind.Local).AddTicks(3445), true });

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 3,
                columns: new[] { "InitialDate", "StudentCompleted" },
                values: new object[] { new DateTime(2021, 8, 3, 19, 18, 10, 702, DateTimeKind.Local).AddTicks(3542), true });

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 4,
                columns: new[] { "InitialDate", "PreceptorInitial" },
                values: new object[] { new DateTime(2021, 8, 3, 19, 18, 10, 702, DateTimeKind.Local).AddTicks(3555), "" });

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 5,
                columns: new[] { "InitialDate", "StudentCompleted" },
                values: new object[] { new DateTime(2021, 8, 3, 19, 18, 10, 702, DateTimeKind.Local).AddTicks(3560), true });

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 6,
                columns: new[] { "InitialDate", "PreceptorInitial" },
                values: new object[] { new DateTime(2021, 8, 3, 19, 18, 10, 702, DateTimeKind.Local).AddTicks(3565), "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentCompleted",
                table: "TaskCompletions");

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 1,
                columns: new[] { "InitialDate", "PreceptorInitial" },
                values: new object[] { new DateTime(2021, 7, 26, 20, 19, 23, 39, DateTimeKind.Local).AddTicks(8999), "JP" });

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 2,
                column: "InitialDate",
                value: new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 3,
                column: "InitialDate",
                value: new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 4,
                columns: new[] { "InitialDate", "PreceptorInitial" },
                values: new object[] { new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7849), "JP" });

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 5,
                column: "InitialDate",
                value: new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 6,
                columns: new[] { "InitialDate", "PreceptorInitial" },
                values: new object[] { new DateTime(2021, 7, 26, 20, 19, 23, 41, DateTimeKind.Local).AddTicks(7855), "JP" });
        }
    }
}
