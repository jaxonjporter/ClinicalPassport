using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicalPassport.Migrations
{
    public partial class addStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 1,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 51, 240, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 2,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 51, 242, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 3,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 51, 242, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 4,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 51, 242, DateTimeKind.Local).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 5,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 51, 242, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 6,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 51, 242, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 7,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 51, 242, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 8,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 51, 242, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 9,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 51, 242, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 10,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 51, 242, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 11,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 51, 242, DateTimeKind.Local).AddTicks(9242));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 1,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 3, 394, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 2,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 3, 397, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 3,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 3, 397, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 4,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 3, 397, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 5,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 3, 397, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 6,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 3, 397, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 7,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 3, 397, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 8,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 3, 397, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 9,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 3, 397, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 10,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 3, 397, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "TaskCompletions",
                keyColumn: "TaskCompletionId",
                keyValue: 11,
                column: "InitialDate",
                value: new DateTime(2021, 8, 6, 19, 7, 3, 397, DateTimeKind.Local).AddTicks(2367));
        }
    }
}
